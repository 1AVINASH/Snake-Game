namespace Snake_Game
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
            this.components = new System.ComponentModel.Container();
            this.GameBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.highScore = new System.Windows.Forms.Label();
            this.levels = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.level5 = new System.Windows.Forms.RadioButton();
            this.level4 = new System.Windows.Forms.RadioButton();
            this.level3 = new System.Windows.Forms.RadioButton();
            this.level2 = new System.Windows.Forms.RadioButton();
            this.level1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameBox
            // 
            this.GameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameBox.Location = new System.Drawing.Point(12, 8);
            this.GameBox.Name = "GameBox";
            this.GameBox.Size = new System.Drawing.Size(438, 438);
            this.GameBox.TabIndex = 0;
            this.GameBox.TabStop = false;
            this.GameBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GameBox_Paint);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Kozuka Mincho Pr6N EL", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(612, 34);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(55, 25);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 173);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(10, 37);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "HighScore:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Score:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // highScore
            // 
            this.highScore.AutoSize = true;
            this.highScore.Font = new System.Drawing.Font("Kozuka Mincho Pr6N EL", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore.Location = new System.Drawing.Point(612, 86);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(55, 25);
            this.highScore.TabIndex = 5;
            this.highScore.Text = "label4";
            this.highScore.Click += new System.EventHandler(this.highScore_Click);
            // 
            // levels
            // 
            this.levels.AutoSize = true;
            this.levels.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levels.Location = new System.Drawing.Point(484, 180);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(66, 24);
            this.levels.TabIndex = 6;
            this.levels.Text = "Levels:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.level5);
            this.panel1.Controls.Add(this.level4);
            this.panel1.Controls.Add(this.level3);
            this.panel1.Controls.Add(this.level2);
            this.panel1.Controls.Add(this.level1);
            this.panel1.Location = new System.Drawing.Point(576, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 202);
            this.panel1.TabIndex = 7;
            // 
            // level5
            // 
            this.level5.AutoSize = true;
            this.level5.Location = new System.Drawing.Point(4, 169);
            this.level5.Name = "level5";
            this.level5.Size = new System.Drawing.Size(75, 21);
            this.level5.TabIndex = 4;
            this.level5.TabStop = true;
            this.level5.Text = "Level 5";
            this.level5.UseVisualStyleBackColor = true;
            // 
            // level4
            // 
            this.level4.AutoSize = true;
            this.level4.Location = new System.Drawing.Point(4, 133);
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(75, 21);
            this.level4.TabIndex = 3;
            this.level4.TabStop = true;
            this.level4.Text = "Level 4";
            this.level4.UseVisualStyleBackColor = true;
            // 
            // level3
            // 
            this.level3.AutoSize = true;
            this.level3.Location = new System.Drawing.Point(4, 95);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(75, 21);
            this.level3.TabIndex = 2;
            this.level3.TabStop = true;
            this.level3.Text = "Level 3";
            this.level3.UseVisualStyleBackColor = true;
            // 
            // level2
            // 
            this.level2.AutoSize = true;
            this.level2.Location = new System.Drawing.Point(4, 56);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(75, 21);
            this.level2.TabIndex = 1;
            this.level2.TabStop = true;
            this.level2.Text = "Level 2";
            this.level2.UseVisualStyleBackColor = true;
            // 
            // level1
            // 
            this.level1.AutoSize = true;
            this.level1.Checked = true;
            this.level1.Location = new System.Drawing.Point(4, 15);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(75, 21);
            this.level1.TabIndex = 0;
            this.level1.TabStop = true;
            this.level1.Text = "Level 1";
            this.level1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(488, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.levels);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.GameBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label highScore;
        private System.Windows.Forms.Label levels;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton level5;
        private System.Windows.Forms.RadioButton level4;
        private System.Windows.Forms.RadioButton level3;
        private System.Windows.Forms.RadioButton level2;
        private System.Windows.Forms.RadioButton level1;
        private System.Windows.Forms.Button button1;
    }
}

