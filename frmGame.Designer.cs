namespace TicTacToe
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pbTurn = new System.Windows.Forms.PictureBox();
            this.lbWinner = new System.Windows.Forms.Label();
            this.btRestart = new System.Windows.Forms.Button();
            this.lbTurn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.gpCards = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTurn)).BeginInit();
            this.gpCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTurn
            // 
            this.pbTurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTurn.Image = global::TicTacToe.Properties.Resources.questionImage;
            this.pbTurn.Location = new System.Drawing.Point(669, 224);
            this.pbTurn.Margin = new System.Windows.Forms.Padding(4);
            this.pbTurn.Name = "pbTurn";
            this.pbTurn.Size = new System.Drawing.Size(39, 33);
            this.pbTurn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTurn.TabIndex = 9;
            this.pbTurn.TabStop = false;
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Location = new System.Drawing.Point(683, 348);
            this.lbWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(0, 16);
            this.lbWinner.TabIndex = 10;
            // 
            // btRestart
            // 
            this.btRestart.BackgroundImage = global::TicTacToe.Properties.Resources.RestsartbuttonImage;
            this.btRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRestart.Location = new System.Drawing.Point(652, 401);
            this.btRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(179, 57);
            this.btRestart.TabIndex = 11;
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.Location = new System.Drawing.Point(716, 234);
            this.lbTurn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(0, 16);
            this.lbTurn.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TicTacToe.Properties.Resources.QuesImage2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(34, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 95);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Tag = "00";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TicTacToe.Properties.Resources.QuesImage2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(142, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 95);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Tag = "01";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::TicTacToe.Properties.Resources.QuesImage2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(252, 29);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 95);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Tag = "02";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::TicTacToe.Properties.Resources.QuesImage2;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(34, 140);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 95);
            this.button6.TabIndex = 3;
            this.button6.TabStop = false;
            this.button6.Tag = "10";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::TicTacToe.Properties.Resources.QuesImage2;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(142, 140);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 95);
            this.button5.TabIndex = 4;
            this.button5.Tag = "11";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::TicTacToe.Properties.Resources.QuesImage2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(252, 140);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 95);
            this.button4.TabIndex = 5;
            this.button4.Tag = "12";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::TicTacToe.Properties.Resources.QuesImage2;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(34, 250);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 95);
            this.button9.TabIndex = 6;
            this.button9.Tag = "20";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::TicTacToe.Properties.Resources.QuesImage2;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(142, 250);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 95);
            this.button8.TabIndex = 7;
            this.button8.Tag = "21";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::TicTacToe.Properties.Resources.QuesImage2;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(252, 250);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 95);
            this.button7.TabIndex = 8;
            this.button7.Tag = "22";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // gpCards
            // 
            this.gpCards.Controls.Add(this.button7);
            this.gpCards.Controls.Add(this.button8);
            this.gpCards.Controls.Add(this.button9);
            this.gpCards.Controls.Add(this.button4);
            this.gpCards.Controls.Add(this.button5);
            this.gpCards.Controls.Add(this.button6);
            this.gpCards.Controls.Add(this.button3);
            this.gpCards.Controls.Add(this.button2);
            this.gpCards.Controls.Add(this.button1);
            this.gpCards.Location = new System.Drawing.Point(227, 165);
            this.gpCards.Name = "gpCards";
            this.gpCards.Size = new System.Drawing.Size(374, 372);
            this.gpCards.TabIndex = 13;
            this.gpCards.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::TicTacToe.Properties.Resources.BackImage;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(41, 530);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(179, 71);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.GameScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 629);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gpCards);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.pbTurn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTurn)).EndInit();
            this.gpCards.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pbTurn;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox gpCards;
        private System.Windows.Forms.Button btnBack;
    }
}