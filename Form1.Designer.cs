namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVPlayers = new System.Windows.Forms.DataGridView();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Best_Round = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worst_Round = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPlayers
            // 
            this.DGVPlayers.BackgroundColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerID,
            this.PlayerName,
            this.Best_Round,
            this.Worst_Round});
            this.DGVPlayers.Location = new System.Drawing.Point(-5, 2);
            this.DGVPlayers.Name = "DGVPlayers";
            this.DGVPlayers.Size = new System.Drawing.Size(573, 437);
            this.DGVPlayers.TabIndex = 0;
            // 
            // PlayerID
            // 
            this.PlayerID.HeaderText = "Player_ID";
            this.PlayerID.Name = "PlayerID";
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Player_Name";
            this.PlayerName.Name = "PlayerName";
            // 
            // Best_Round
            // 
            this.Best_Round.HeaderText = "Best_Round";
            this.Best_Round.Name = "Best_Round";
            // 
            // Worst_Round
            // 
            this.Worst_Round.HeaderText = "Worst_Round";
            this.Worst_Round.Name = "Worst_Round";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(570, 430);
            this.Controls.Add(this.DGVPlayers);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Players List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Best_Round;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worst_Round;
    }
}

