namespace Twitchmote
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonStart = new System.Windows.Forms.Button();
            this.consoleTB = new System.Windows.Forms.TextBox();
            this.textBoxGame = new System.Windows.Forms.TextBox();
            this.labelGame = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonConfigKeyboard = new System.Windows.Forms.Button();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.numericUpDownKeyWait = new System.Windows.Forms.NumericUpDown();
            this.labelKeyWait = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyWait)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(258, 6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // consoleTB
            // 
            this.consoleTB.Location = new System.Drawing.Point(258, 35);
            this.consoleTB.Multiline = true;
            this.consoleTB.Name = "consoleTB";
            this.consoleTB.ReadOnly = true;
            this.consoleTB.Size = new System.Drawing.Size(305, 147);
            this.consoleTB.TabIndex = 1;
            // 
            // textBoxGame
            // 
            this.textBoxGame.Location = new System.Drawing.Point(90, 3);
            this.textBoxGame.Name = "textBoxGame";
            this.textBoxGame.Size = new System.Drawing.Size(162, 20);
            this.textBoxGame.TabIndex = 2;
            this.textBoxGame.TextChanged += new System.EventHandler(this.textBoxGame_TextChanged);
            // 
            // labelGame
            // 
            this.labelGame.AutoSize = true;
            this.labelGame.Location = new System.Drawing.Point(46, 6);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(41, 13);
            this.labelGame.TabIndex = 3;
            this.labelGame.Text = "Game: ";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(46, 58);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(38, 13);
            this.labelRoom.TabIndex = 4;
            this.labelRoom.Text = "Room:";
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Location = new System.Drawing.Point(90, 55);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.Size = new System.Drawing.Size(162, 20);
            this.textBoxRoom.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(177, 159);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(358, 6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(52, 84);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(32, 13);
            this.labelUser.TabIndex = 8;
            this.labelUser.Text = "User:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(28, 110);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(90, 81);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(162, 20);
            this.textBoxUser.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(90, 107);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(162, 20);
            this.textBoxPassword.TabIndex = 11;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(488, 6);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 12;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonConfigKeyboard
            // 
            this.buttonConfigKeyboard.Location = new System.Drawing.Point(31, 159);
            this.buttonConfigKeyboard.Name = "buttonConfigKeyboard";
            this.buttonConfigKeyboard.Size = new System.Drawing.Size(121, 23);
            this.buttonConfigKeyboard.TabIndex = 13;
            this.buttonConfigKeyboard.Text = "Configure keyboard";
            this.buttonConfigKeyboard.UseVisualStyleBackColor = true;
            this.buttonConfigKeyboard.Click += new System.EventHandler(this.buttonConfigKeyboard_Click);
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(90, 29);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(162, 20);
            this.textBoxServer.TabIndex = 15;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(43, 32);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(41, 13);
            this.labelServer.TabIndex = 14;
            this.labelServer.Text = "Server:";
            // 
            // numericUpDownKeyWait
            // 
            this.numericUpDownKeyWait.Location = new System.Drawing.Point(90, 133);
            this.numericUpDownKeyWait.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownKeyWait.Name = "numericUpDownKeyWait";
            this.numericUpDownKeyWait.Size = new System.Drawing.Size(162, 20);
            this.numericUpDownKeyWait.TabIndex = 16;
            this.numericUpDownKeyWait.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelKeyWait
            // 
            this.labelKeyWait.AutoSize = true;
            this.labelKeyWait.Location = new System.Drawing.Point(12, 135);
            this.labelKeyWait.Name = "labelKeyWait";
            this.labelKeyWait.Size = new System.Drawing.Size(72, 13);
            this.labelKeyWait.TabIndex = 17;
            this.labelKeyWait.Text = "Key wait (ms):";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 197);
            this.Controls.Add(this.labelKeyWait);
            this.Controls.Add(this.numericUpDownKeyWait);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.buttonConfigKeyboard);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxRoom);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.textBoxGame);
            this.Controls.Add(this.consoleTB);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Twitchmote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyWait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox consoleTB;
        private System.Windows.Forms.TextBox textBoxGame;
        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.TextBox textBoxRoom;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonConfigKeyboard;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.NumericUpDown numericUpDownKeyWait;
        private System.Windows.Forms.Label labelKeyWait;
    }
}

