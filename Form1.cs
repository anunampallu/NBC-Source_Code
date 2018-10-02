using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Dictionary<string, BestWorstRounds> rounds;
        public Dictionary<string, Player> Players;

        public Form1()
        {
            InitializeComponent();

        }

        //on form load attaching data to data grid view
        private void Form1_Load(object sender, EventArgs e)
        {
            Solution solution = new Solution();

            //getting under par players and their best and worst rounds
            rounds = solution.GetBestWorstRounds();

            //getting all players.
            Players = solution.GetPlayersAsDictionary();
            int counter = 0;

            //looping through the round dictionary and adding data to data grid view.
            foreach (string key in rounds.Keys)
            {
                int index = DGVPlayers.Rows.Add();
                if (counter < 3)
                {
                    DGVPlayers.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                    counter++;
                }
                DGVPlayers.Rows[index].Cells[0].Value = key;
                DGVPlayers.Rows[index].Cells[1].Value = Players[key].player_bio.first_name + " " + Players[key].player_bio.last_name;
                DGVPlayers.Rows[index].Cells[2].Value = rounds[key]._Best_Round;
                DGVPlayers.Rows[index].Cells[3].Value = rounds[key]._Worst_Round;

            }           
        }
    }

    public class Solution
    {
        List<string> ListOfUnderParPlayers = new List<string>();
        Dictionary<string, Player> ListOfPlayers = new Dictionary<string, Player>();
        Dictionary<string, BestWorstRounds> ListofBestWorstRounds = new Dictionary<string, BestWorstRounds>();
        List<string> ListOfTopGolfers = new List<string>();
        Dictionary<string, string> ListOfPlayersCurrentPosition = new Dictionary<string,string>();

        public Solution()
        {
            WebRequest request = WebRequest.Create("https://statdata.pgatour.com/r/009/leaderboard-v2mini.json");
            request.Method = "GET";

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/json; charset=utf-8";

            //Get response from web service
            WebResponse response = request.GetResponse();

            using (var s = response.GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var ResponseInJson = sr.ReadToEnd();
                    var DeserialisedResponse = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<RootObject>(ResponseInJson);

                    foreach (Player p in DeserialisedResponse.leaderboard.players)
                    {
                        int flag = 0;
                        for (int i = 0; i < 4; i++)
                        {
                            if (p.rounds[i].strokes < Convert.ToInt32(DeserialisedResponse.leaderboard.courses[0].par_total))
                            {
                                flag = 1;
                            }
                            else
                            {
                                flag = 0;
                                break;
                            }
                        }
                        if (flag == 1)
                        {
                            ListOfUnderParPlayers.Add(p.player_id);
                        }


                        ListOfPlayers.Add(p.player_id.ToString(), p);
                    }                    
                }
            }
        }        

        //To get list of players.
        public Dictionary<string, Player> GetPlayersAsDictionary()
        {
            return ListOfPlayers;
        }

        //To get list of players who are under par
        public List<string> GetUnderParPlayers()
        {
            return ListOfUnderParPlayers;
        }

        //To get list of players who are under par and their best, worst rounds.
        public Dictionary<string, BestWorstRounds> GetBestWorstRounds()
        {            
            foreach (string playerId in ListOfUnderParPlayers)
            {
                if (ListOfPlayers.ContainsKey(playerId))
                {
                    Player p = ListOfPlayers[playerId];
                    int Min = int.MaxValue, Max = 0;
                    int best_Round = 0, worst_Round = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        if (p.rounds[i].strokes < Min)
                        {
                            Min = Convert.ToInt32(p.rounds[i].strokes);
                            best_Round = i;
                            best_Round = ++best_Round;
                        }

                        if (p.rounds[i].strokes > Max)
                        {
                            Max = (int)p.rounds[i].strokes;
                            worst_Round = i;
                            worst_Round = ++worst_Round;
                        }
                        
                    }  
                  
                    BestWorstRounds rounds = new BestWorstRounds();
                    rounds._Best_Round = best_Round;
                    rounds._Worst_Round = worst_Round;
                    ListofBestWorstRounds.Add(playerId, rounds);
                }
            }
            return ListofBestWorstRounds;
        }        
    }

    public class BestWorstRounds
    {
        public int _Best_Round{ get; set;}
        public int _Worst_Round { get; set; }
    }
}