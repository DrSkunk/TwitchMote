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
            this.textBoxNickserv = new System.Windows.Forms.TextBox();
            this.labelNickserv = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyWait)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(258, 6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 9;
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
            this.consoleTB.Size = new System.Drawing.Size(305, 150);
            this.consoleTB.TabIndex = 15;
            // 
            // textBoxGame
            // 
            this.textBoxGame.Location = new System.Drawing.Point(90, 3);
            this.textBoxGame.Name = "textBoxGame";
            this.textBoxGame.Size = new System.Drawing.Size(162, 20);
            this.textBoxGame.TabIndex = 1;
            this.textBoxGame.TextChanged += new System.EventHandler(this.textBoxGame_TextChanged);
            // 
            // labelGame
            // 
            this.labelGame.AutoSize = true;
            this.labelGame.Location = new System.Drawing.Point(46, 6);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(41, 13);
            this.labelGame.TabIndex = 16;
            this.labelGame.Text = "Game: ";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(46, 58);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(38, 13);
            this.labelRoom.TabIndex = 18;
            this.labelRoom.Text = "Room:";
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Location = new System.Drawing.Point(90, 55);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.Size = new System.Drawing.Size(162, 20);
            this.textBoxRoom.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(177, 191);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(374, 6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 10;
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
            this.labelUser.TabIndex = 19;
            this.labelUser.Text = "User:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(28, 110);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 20;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(90, 81);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(162, 20);
            this.textBoxUser.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(90, 107);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(162, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(488, 6);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 14;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonConfigKeyboard
            // 
            this.buttonConfigKeyboard.Location = new System.Drawing.Point(35, 191);
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
            this.textBoxServer.TabIndex = 2;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(43, 32);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(41, 13);
            this.labelServer.TabIndex = 17;
            this.labelServer.Text = "Server:";
            // 
            // numericUpDownKeyWait
            // 
            this.numericUpDownKeyWait.Location = new System.Drawing.Point(90, 162);
            this.numericUpDownKeyWait.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownKeyWait.Name = "numericUpDownKeyWait";
            this.numericUpDownKeyWait.Size = new System.Drawing.Size(162, 20);
            this.numericUpDownKeyWait.TabIndex = 7;
            this.numericUpDownKeyWait.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelKeyWait
            // 
            this.labelKeyWait.AutoSize = true;
            this.labelKeyWait.Location = new System.Drawing.Point(12, 164);
            this.labelKeyWait.Name = "labelKeyWait";
            this.labelKeyWait.Size = new System.Drawing.Size(72, 13);
            this.labelKeyWait.TabIndex = 22;
            this.labelKeyWait.Text = "Key wait (ms):";
            // 
            // textBoxNickserv
            // 
            this.textBoxNickserv.Location = new System.Drawing.Point(90, 133);
            this.textBoxNickserv.Name = "textBoxNickserv";
            this.textBoxNickserv.PasswordChar = '*';
            this.textBoxNickserv.Size = new System.Drawing.Size(162, 20);
            this.textBoxNickserv.TabIndex = 6;
            // 
            // labelNickserv
            // 
            this.labelNickserv.AutoSize = true;
            this.labelNickserv.Location = new System.Drawing.Point(32, 136);
            this.labelNickserv.Name = "labelNickserv";
            this.labelNickserv.Size = new System.Drawing.Size(52, 13);
            this.labelNickserv.TabIndex = 21;
            this.labelNickserv.Text = "Nickserv:";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(258, 191);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(226, 20);
            this.textBoxCommand.TabIndex = 11;
            this.textBoxCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCommand_KeyDown);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(490, 191);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 222);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.textBoxNickserv);
            this.Controls.Add(this.labelNickserv);
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
        private System.Windows.Forms.TextBox textBoxNickserv;
        private System.Windows.Forms.Label labelNickserv;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

