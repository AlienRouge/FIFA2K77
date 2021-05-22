
namespace FIFA2077
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Looses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Draws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayNextDay = new System.Windows.Forms.Button();
            this.winnerLbl = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.dayLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Team,
            this.Wins,
            this.Looses,
            this.Draws,
            this.Goals,
            this.Score,
            this.AvgGoals});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.Name = "Team";
            // 
            // Wins
            // 
            dataGridViewCellStyle1.NullValue = "0";
            this.Wins.DefaultCellStyle = dataGridViewCellStyle1;
            this.Wins.HeaderText = "Wins";
            this.Wins.Name = "Wins";
            this.Wins.ReadOnly = true;
            // 
            // Looses
            // 
            this.Looses.HeaderText = "Looses";
            this.Looses.Name = "Looses";
            this.Looses.ReadOnly = true;
            // 
            // Draws
            // 
            this.Draws.HeaderText = "Draws";
            this.Draws.Name = "Draws";
            this.Draws.ReadOnly = true;
            // 
            // Goals
            // 
            dataGridViewCellStyle2.NullValue = "0";
            this.Goals.DefaultCellStyle = dataGridViewCellStyle2;
            this.Goals.HeaderText = "Goals";
            this.Goals.Name = "Goals";
            this.Goals.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // AvgGoals
            // 
            this.AvgGoals.HeaderText = "AvgGoals";
            this.AvgGoals.Name = "AvgGoals";
            this.AvgGoals.ReadOnly = true;
            this.AvgGoals.Visible = false;
            // 
            // PlayNextDay
            // 
            this.PlayNextDay.Location = new System.Drawing.Point(31, 286);
            this.PlayNextDay.Name = "PlayNextDay";
            this.PlayNextDay.Size = new System.Drawing.Size(89, 38);
            this.PlayNextDay.TabIndex = 1;
            this.PlayNextDay.Text = "NextDay";
            this.PlayNextDay.UseVisualStyleBackColor = true;
            this.PlayNextDay.Click += new System.EventHandler(this.PlayNextDay_Click);
            // 
            // winnerLbl
            // 
            this.winnerLbl.AutoSize = true;
            this.winnerLbl.Location = new System.Drawing.Point(177, 256);
            this.winnerLbl.Name = "winnerLbl";
            this.winnerLbl.Size = new System.Drawing.Size(0, 13);
            this.winnerLbl.TabIndex = 2;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(12, 244);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(124, 36);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Create Championship";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // dayLbl
            // 
            this.dayLbl.AutoSize = true;
            this.dayLbl.Location = new System.Drawing.Point(12, 228);
            this.dayLbl.Name = "dayLbl";
            this.dayLbl.Size = new System.Drawing.Size(0, 13);
            this.dayLbl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 337);
            this.Controls.Add(this.dayLbl);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.winnerLbl);
            this.Controls.Add(this.PlayNextDay);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "FIFA2K77";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PlayNextDay;
        private System.Windows.Forms.Label winnerLbl;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label dayLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Looses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Draws;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgGoals;
    }
}

