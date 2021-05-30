namespace TLvov_TowersOfHanoi_Ver2
{
    partial class frmTowersOfHanoi
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
            this.sldTowers = new System.Windows.Forms.TrackBar();
            this.picBoxTowerDisplay = new System.Windows.Forms.PictureBox();
            this.sldDisks = new System.Windows.Forms.TrackBar();
            this.lblNumOfTowers = new System.Windows.Forms.Label();
            this.lblNumOfDisks = new System.Windows.Forms.Label();
            this.lblThree_1 = new System.Windows.Forms.Label();
            this.lblFour_1 = new System.Windows.Forms.Label();
            this.lblFive_1 = new System.Windows.Forms.Label();
            this.lblThree_2 = new System.Windows.Forms.Label();
            this.lblFour_2 = new System.Windows.Forms.Label();
            this.lblFive_2 = new System.Windows.Forms.Label();
            this.lblSix = new System.Windows.Forms.Label();
            this.lblSeven = new System.Windows.Forms.Label();
            this.txtGameInfo = new System.Windows.Forms.TextBox();
            this.cmdRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sldTowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTowerDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldDisks)).BeginInit();
            this.SuspendLayout();
            // 
            // sldTowers
            // 
            this.sldTowers.Location = new System.Drawing.Point(170, 388);
            this.sldTowers.Maximum = 5;
            this.sldTowers.Minimum = 3;
            this.sldTowers.Name = "sldTowers";
            this.sldTowers.Size = new System.Drawing.Size(270, 45);
            this.sldTowers.TabIndex = 3;
            this.sldTowers.Value = 3;
            this.sldTowers.ValueChanged += new System.EventHandler(this.sldTowers_ValueChanged);
            // 
            // picBoxTowerDisplay
            // 
            this.picBoxTowerDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBoxTowerDisplay.Location = new System.Drawing.Point(56, 12);
            this.picBoxTowerDisplay.Name = "picBoxTowerDisplay";
            this.picBoxTowerDisplay.Size = new System.Drawing.Size(850, 360);
            this.picBoxTowerDisplay.TabIndex = 2;
            this.picBoxTowerDisplay.TabStop = false;
            this.picBoxTowerDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxTowerDisplay_MouseDown);
            this.picBoxTowerDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxTowerDisplay_MouseMove);
            this.picBoxTowerDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxTowerDisplay_MouseUp);
            // 
            // sldDisks
            // 
            this.sldDisks.Location = new System.Drawing.Point(170, 470);
            this.sldDisks.Maximum = 7;
            this.sldDisks.Minimum = 3;
            this.sldDisks.Name = "sldDisks";
            this.sldDisks.Size = new System.Drawing.Size(270, 45);
            this.sldDisks.TabIndex = 4;
            this.sldDisks.Value = 3;
            this.sldDisks.ValueChanged += new System.EventHandler(this.sldDisks_ValueChanged);
            // 
            // lblNumOfTowers
            // 
            this.lblNumOfTowers.AutoSize = true;
            this.lblNumOfTowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfTowers.Location = new System.Drawing.Point(53, 388);
            this.lblNumOfTowers.Name = "lblNumOfTowers";
            this.lblNumOfTowers.Size = new System.Drawing.Size(111, 15);
            this.lblNumOfTowers.TabIndex = 5;
            this.lblNumOfTowers.Text = "Number of Towers:";
            // 
            // lblNumOfDisks
            // 
            this.lblNumOfDisks.AutoSize = true;
            this.lblNumOfDisks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfDisks.Location = new System.Drawing.Point(63, 470);
            this.lblNumOfDisks.Name = "lblNumOfDisks";
            this.lblNumOfDisks.Size = new System.Drawing.Size(101, 15);
            this.lblNumOfDisks.TabIndex = 6;
            this.lblNumOfDisks.Text = "Number of Disks:";
            // 
            // lblThree_1
            // 
            this.lblThree_1.AutoSize = true;
            this.lblThree_1.ForeColor = System.Drawing.Color.DimGray;
            this.lblThree_1.Location = new System.Drawing.Point(177, 420);
            this.lblThree_1.Name = "lblThree_1";
            this.lblThree_1.Size = new System.Drawing.Size(13, 13);
            this.lblThree_1.TabIndex = 7;
            this.lblThree_1.Text = "3";
            // 
            // lblFour_1
            // 
            this.lblFour_1.AutoSize = true;
            this.lblFour_1.ForeColor = System.Drawing.Color.DimGray;
            this.lblFour_1.Location = new System.Drawing.Point(300, 420);
            this.lblFour_1.Name = "lblFour_1";
            this.lblFour_1.Size = new System.Drawing.Size(13, 13);
            this.lblFour_1.TabIndex = 8;
            this.lblFour_1.Text = "4";
            // 
            // lblFive_1
            // 
            this.lblFive_1.AutoSize = true;
            this.lblFive_1.ForeColor = System.Drawing.Color.DimGray;
            this.lblFive_1.Location = new System.Drawing.Point(420, 420);
            this.lblFive_1.Name = "lblFive_1";
            this.lblFive_1.Size = new System.Drawing.Size(13, 13);
            this.lblFive_1.TabIndex = 9;
            this.lblFive_1.Text = "5";
            // 
            // lblThree_2
            // 
            this.lblThree_2.AutoSize = true;
            this.lblThree_2.ForeColor = System.Drawing.Color.DimGray;
            this.lblThree_2.Location = new System.Drawing.Point(177, 502);
            this.lblThree_2.Name = "lblThree_2";
            this.lblThree_2.Size = new System.Drawing.Size(13, 13);
            this.lblThree_2.TabIndex = 10;
            this.lblThree_2.Text = "3";
            // 
            // lblFour_2
            // 
            this.lblFour_2.AutoSize = true;
            this.lblFour_2.ForeColor = System.Drawing.Color.DimGray;
            this.lblFour_2.Location = new System.Drawing.Point(237, 502);
            this.lblFour_2.Name = "lblFour_2";
            this.lblFour_2.Size = new System.Drawing.Size(13, 13);
            this.lblFour_2.TabIndex = 11;
            this.lblFour_2.Text = "4";
            // 
            // lblFive_2
            // 
            this.lblFive_2.AutoSize = true;
            this.lblFive_2.ForeColor = System.Drawing.Color.DimGray;
            this.lblFive_2.Location = new System.Drawing.Point(300, 502);
            this.lblFive_2.Name = "lblFive_2";
            this.lblFive_2.Size = new System.Drawing.Size(13, 13);
            this.lblFive_2.TabIndex = 12;
            this.lblFive_2.Text = "5";
            // 
            // lblSix
            // 
            this.lblSix.AutoSize = true;
            this.lblSix.ForeColor = System.Drawing.Color.DimGray;
            this.lblSix.Location = new System.Drawing.Point(359, 502);
            this.lblSix.Name = "lblSix";
            this.lblSix.Size = new System.Drawing.Size(13, 13);
            this.lblSix.TabIndex = 13;
            this.lblSix.Text = "6";
            // 
            // lblSeven
            // 
            this.lblSeven.AutoSize = true;
            this.lblSeven.ForeColor = System.Drawing.Color.DimGray;
            this.lblSeven.Location = new System.Drawing.Point(420, 502);
            this.lblSeven.Name = "lblSeven";
            this.lblSeven.Size = new System.Drawing.Size(13, 13);
            this.lblSeven.TabIndex = 14;
            this.lblSeven.Text = "7";
            // 
            // txtGameInfo
            // 
            this.txtGameInfo.Location = new System.Drawing.Point(630, 387);
            this.txtGameInfo.Multiline = true;
            this.txtGameInfo.Name = "txtGameInfo";
            this.txtGameInfo.ReadOnly = true;
            this.txtGameInfo.Size = new System.Drawing.Size(276, 139);
            this.txtGameInfo.TabIndex = 15;
            // 
            // cmdRestart
            // 
            this.cmdRestart.Location = new System.Drawing.Point(463, 387);
            this.cmdRestart.Name = "cmdRestart";
            this.cmdRestart.Size = new System.Drawing.Size(150, 65);
            this.cmdRestart.TabIndex = 16;
            this.cmdRestart.Text = "Restart";
            this.cmdRestart.UseVisualStyleBackColor = true;
            this.cmdRestart.Click += new System.EventHandler(this.cmdRestart_Click);
            // 
            // frmTowersOfHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(990, 550);
            this.Controls.Add(this.cmdRestart);
            this.Controls.Add(this.txtGameInfo);
            this.Controls.Add(this.lblSeven);
            this.Controls.Add(this.lblSix);
            this.Controls.Add(this.lblFive_2);
            this.Controls.Add(this.lblFour_2);
            this.Controls.Add(this.lblThree_2);
            this.Controls.Add(this.lblFive_1);
            this.Controls.Add(this.lblFour_1);
            this.Controls.Add(this.lblThree_1);
            this.Controls.Add(this.lblNumOfDisks);
            this.Controls.Add(this.lblNumOfTowers);
            this.Controls.Add(this.sldDisks);
            this.Controls.Add(this.sldTowers);
            this.Controls.Add(this.picBoxTowerDisplay);
            this.Name = "frmTowersOfHanoi";
            this.Text = "Towers of Hanoi";
            ((System.ComponentModel.ISupportInitialize)(this.sldTowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTowerDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldDisks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar sldTowers;
        private System.Windows.Forms.PictureBox picBoxTowerDisplay;
        private System.Windows.Forms.TrackBar sldDisks;
        private System.Windows.Forms.Label lblNumOfTowers;
        private System.Windows.Forms.Label lblNumOfDisks;
        private System.Windows.Forms.Label lblThree_1;
        private System.Windows.Forms.Label lblFour_1;
        private System.Windows.Forms.Label lblFive_1;
        private System.Windows.Forms.Label lblThree_2;
        private System.Windows.Forms.Label lblFour_2;
        private System.Windows.Forms.Label lblFive_2;
        private System.Windows.Forms.Label lblSix;
        private System.Windows.Forms.Label lblSeven;
        private System.Windows.Forms.TextBox txtGameInfo;
        private System.Windows.Forms.Button cmdRestart;
    }
}

