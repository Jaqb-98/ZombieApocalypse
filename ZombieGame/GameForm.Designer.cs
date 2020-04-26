namespace ZombieGame
{
    partial class GameForm
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
            this.GamePanel = new System.Windows.Forms.Panel();
            this.txt_NumberOfHumans = new System.Windows.Forms.TextBox();
            this.txt_NumberOfSoldiers = new System.Windows.Forms.TextBox();
            this.txt_NumberOfZombies = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.btn_NextTurn = new System.Windows.Forms.Button();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Turns = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamePanel.Location = new System.Drawing.Point(95, 12);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(300, 300);
            this.GamePanel.TabIndex = 0;
            // 
            // txt_NumberOfHumans
            // 
            this.txt_NumberOfHumans.Location = new System.Drawing.Point(110, 347);
            this.txt_NumberOfHumans.Name = "txt_NumberOfHumans";
            this.txt_NumberOfHumans.Size = new System.Drawing.Size(62, 22);
            this.txt_NumberOfHumans.TabIndex = 1;
            // 
            // txt_NumberOfSoldiers
            // 
            this.txt_NumberOfSoldiers.Location = new System.Drawing.Point(110, 425);
            this.txt_NumberOfSoldiers.Name = "txt_NumberOfSoldiers";
            this.txt_NumberOfSoldiers.Size = new System.Drawing.Size(62, 22);
            this.txt_NumberOfSoldiers.TabIndex = 2;
            // 
            // txt_NumberOfZombies
            // 
            this.txt_NumberOfZombies.Location = new System.Drawing.Point(110, 386);
            this.txt_NumberOfZombies.Name = "txt_NumberOfZombies";
            this.txt_NumberOfZombies.Size = new System.Drawing.Size(62, 22);
            this.txt_NumberOfZombies.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Humans: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zombies: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soldiers: ";
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.Location = new System.Drawing.Point(19, 466);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(153, 36);
            this.btn_StartGame.TabIndex = 7;
            this.btn_StartGame.Text = "Start";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            // 
            // btn_NextTurn
            // 
            this.btn_NextTurn.Enabled = false;
            this.btn_NextTurn.Location = new System.Drawing.Point(251, 329);
            this.btn_NextTurn.Name = "btn_NextTurn";
            this.btn_NextTurn.Size = new System.Drawing.Size(123, 79);
            this.btn_NextTurn.TabIndex = 8;
            this.btn_NextTurn.Text = "Next turn";
            this.btn_NextTurn.UseVisualStyleBackColor = true;
            this.btn_NextTurn.Click += new System.EventHandler(this.btn_NextRound_Click);
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Enabled = false;
            this.btn_NewGame.Location = new System.Drawing.Point(251, 430);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(123, 72);
            this.btn_NewGame.TabIndex = 9;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // lbl_Turns
            // 
            this.lbl_Turns.AutoSize = true;
            this.lbl_Turns.Location = new System.Drawing.Point(14, 20);
            this.lbl_Turns.Name = "lbl_Turns";
            this.lbl_Turns.Size = new System.Drawing.Size(0, 17);
            this.lbl_Turns.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZombieGame.Properties.Resources.Human;
            this.pictureBox1.Location = new System.Drawing.Point(19, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ZombieGame.Properties.Resources.Zombie;
            this.pictureBox2.Location = new System.Drawing.Point(19, 390);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 10);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ZombieGame.Properties.Resources.Soldier;
            this.pictureBox3.Location = new System.Drawing.Point(19, 430);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 10);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 516);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Turns);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.btn_NextTurn);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NumberOfZombies);
            this.Controls.Add(this.txt_NumberOfSoldiers);
            this.Controls.Add(this.txt_NumberOfHumans);
            this.Controls.Add(this.GamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Zombie Apocalypse";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.TextBox txt_NumberOfHumans;
        private System.Windows.Forms.TextBox txt_NumberOfSoldiers;
        private System.Windows.Forms.TextBox txt_NumberOfZombies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.Button btn_NextTurn;
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Label lbl_Turns;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

