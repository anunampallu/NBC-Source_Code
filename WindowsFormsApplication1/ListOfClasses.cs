using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    //Classes for deserialisation of JSon

    public class Debug
    {
        public string msg_id { get; set; }
        public bool setup_file_found { get; set; }
        public DateTime setup_generated { get; set; }
        public string setup_year { get; set; }
        public int current_round_in_setup { get; set; }
        public int last_round_in_setup { get; set; }
        public bool schedule_file_found { get; set; }
        public DateTime schedule_generated { get; set; }
        public bool tournament_in_schedule_file_found { get; set; }
        public string tournament_in_schedule_file_name { get; set; }
        public string format_in_schedule_file_name { get; set; }
    }

    public class Cours
    {
        public string course_id { get; set; }
        public string course_code { get; set; }
        public string course_name { get; set; }
        public bool is_host { get; set; }
        public string par_in { get; set; }
        public string par_out { get; set; }
        public string par_total { get; set; }
        public int distance_in { get; set; }
        public int distance_out { get; set; }
        public int distance_total { get; set; }
    }

    public class CutLine
    {
        public bool show_cut_line { get; set; }
        public int cut_count { get; set; }
        public int cut_line_score { get; set; }
        public bool show_projected { get; set; }
        public int projected_count { get; set; }
        public int paid_players_making_cut { get; set; }
    }

    public class Debug2
    {
        public bool found_in_setup_file { get; set; }
    }

    public class PlayerBio
    {
        public bool is_amateur { get; set; }
        public string first_name { get; set; }
        public string short_name { get; set; }
        public string last_name { get; set; }
        public string country { get; set; }
        public bool is_member { get; set; }
    }

    public class Round
    {
        public int round_number { get; set; }
        public int? strokes { get; set; }
        public DateTime? tee_time { get; set; }
    }

    public class Rankings
    {
        public int? cup_points { get; set; }
        public string cup_rank { get; set; }
        public int? cup_trailing { get; set; }
        public int? projected_cup_points_total { get; set; }
        public int? projected_cup_points_event { get; set; }
        public string projected_cup_rank { get; set; }
        public int? projected_money_total { get; set; }
        public int projected_money_event { get; set; }
        public string projected_money_rank { get; set; }
        public string priority_proj_rank { get; set; }
        public object priority_proj_sort { get; set; }
        public string priority_start_rank { get; set; }
        public object priority_start_sort { get; set; }
        public object priority_seed { get; set; }
        public string schwab_start_rank { get; set; }
        public string schwab_proj_rank { get; set; }
        public string money_start_rank { get; set; }
        public string money_proj_rank { get; set; }
        public object top25_seed { get; set; }
        public string start_rank { get; set; }
        public string proj_rank { get; set; }
        public object proj_sort { get; set; }
    }

    public class Player
    {
        public Debug2 debug { get; set; }
        public string player_id { get; set; }
        public PlayerBio player_bio { get; set; }
        public string current_position { get; set; }
        public string start_position { get; set; }
        public string status { get; set; }
        public int? thru { get; set; }
        public int? start_hole { get; set; }
        public string course_id { get; set; }
        public int? current_round { get; set; }
        public int? course_hole { get; set; }
        public int? today { get; set; }
        public int? total { get; set; }
        public int total_strokes { get; set; }
        public List<Round> rounds { get; set; }
        public Rankings rankings { get; set; }
        public string group_id { get; set; }
    }

    public class Leaderboard
    {
        public string tour_code { get; set; }
        public string tour_name { get; set; }
        public string tournament_id { get; set; }
        public string tournament_name { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string tournament_format { get; set; }
        public string scoring_type { get; set; }
        public bool in_cup { get; set; }
        public int total_rounds { get; set; }
        public bool is_started { get; set; }
        public bool is_finished { get; set; }
        public int current_round { get; set; }
        public string round_state { get; set; }
        public bool in_playoff { get; set; }
        public List<Cours> courses { get; set; }
        public CutLine cut_line { get; set; }
        public List<Player> players { get; set; }
    }

    public class RootObject
    {
        public Debug debug { get; set; }
        public DateTime last_updated { get; set; }
        public string time_stamp { get; set; }
        public Leaderboard leaderboard { get; set; }
    }
}
