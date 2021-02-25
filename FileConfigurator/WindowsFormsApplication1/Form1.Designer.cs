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
            this.AmazonConsole = new System.Windows.Forms.RadioButton();
            this.AmazonServer = new System.Windows.Forms.RadioButton();
            this.AmazonReplay = new System.Windows.Forms.RadioButton();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.Screen = new System.Windows.Forms.TabPage();
            this.Disco = new System.Windows.Forms.TabPage();
            this.Network = new System.Windows.Forms.TabPage();
            this.DataBase = new System.Windows.Forms.TabPage();
            this.Assets = new System.Windows.Forms.TabPage();
            this.Misilinious = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // AmazonConsole
            // 
            this.AmazonConsole.AutoSize = true;
            this.AmazonConsole.Checked = true;
            this.AmazonConsole.Location = new System.Drawing.Point(24, 26);
            this.AmazonConsole.Name = "AmazonConsole";
            this.AmazonConsole.Size = new System.Drawing.Size(101, 17);
            this.AmazonConsole.TabIndex = 0;
            this.AmazonConsole.TabStop = true;
            this.AmazonConsole.Text = "AmazonConsole";
            this.AmazonConsole.UseVisualStyleBackColor = true;
            this.AmazonConsole.Click += new System.EventHandler(this.AmazonConsole_Click);
            // 
            // AmazonServer
            // 
            this.AmazonServer.AutoSize = true;
            this.AmazonServer.Location = new System.Drawing.Point(121, 26);
            this.AmazonServer.Name = "AmazonServer";
            this.AmazonServer.Size = new System.Drawing.Size(94, 17);
            this.AmazonServer.TabIndex = 1;
            this.AmazonServer.TabStop = true;
            this.AmazonServer.Text = "AmazonServer";
            this.AmazonServer.UseVisualStyleBackColor = true;
            this.AmazonServer.Visible = false;
            this.AmazonServer.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.AmazonServer.Click += new System.EventHandler(this.AmazonServer_Click);
            // 
            // AmazonReplay
            // 
            this.AmazonReplay.AutoSize = true;
            this.AmazonReplay.Location = new System.Drawing.Point(217, 26);
            this.AmazonReplay.Name = "AmazonReplay";
            this.AmazonReplay.Size = new System.Drawing.Size(96, 17);
            this.AmazonReplay.TabIndex = 2;
            this.AmazonReplay.TabStop = true;
            this.AmazonReplay.Text = "AmazonReplay";
            this.AmazonReplay.UseVisualStyleBackColor = true;
            this.AmazonReplay.Visible = false;
            this.AmazonReplay.Click += new System.EventHandler(this.AmazonReplay_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.Screen);
            this.tabControlMain.Controls.Add(this.Disco);
            this.tabControlMain.Controls.Add(this.Network);
            this.tabControlMain.Controls.Add(this.DataBase);
            this.tabControlMain.Controls.Add(this.Assets);
            this.tabControlMain.Controls.Add(this.Misilinious);
            this.tabControlMain.Location = new System.Drawing.Point(24, 49);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(995, 413);
            this.tabControlMain.TabIndex = 3;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // Screen
            // 
            this.Screen.Location = new System.Drawing.Point(4, 22);
            this.Screen.Name = "Screen";
            this.Screen.Padding = new System.Windows.Forms.Padding(3);
            this.Screen.Size = new System.Drawing.Size(987, 387);
            this.Screen.TabIndex = 0;
            this.Screen.Text = "Screen";
            this.Screen.UseVisualStyleBackColor = true;
            // 
            // Disco
            // 
            this.Disco.Location = new System.Drawing.Point(4, 22);
            this.Disco.Name = "Disco";
            this.Disco.Padding = new System.Windows.Forms.Padding(3);
            this.Disco.Size = new System.Drawing.Size(987, 387);
            this.Disco.TabIndex = 1;
            this.Disco.Text = "Disco";
            this.Disco.UseVisualStyleBackColor = true;
            // 
            // Network
            // 
            this.Network.Location = new System.Drawing.Point(4, 22);
            this.Network.Name = "Network";
            this.Network.Size = new System.Drawing.Size(987, 387);
            this.Network.TabIndex = 2;
            this.Network.Text = "Network";
            this.Network.UseVisualStyleBackColor = true;
            // 
            // DataBase
            // 
            this.DataBase.Location = new System.Drawing.Point(4, 22);
            this.DataBase.Name = "DataBase";
            this.DataBase.Size = new System.Drawing.Size(987, 387);
            this.DataBase.TabIndex = 3;
            this.DataBase.Text = "DataBase";
            this.DataBase.UseVisualStyleBackColor = true;
            // 
            // Assets
            // 
            this.Assets.Location = new System.Drawing.Point(4, 22);
            this.Assets.Name = "Assets";
            this.Assets.Size = new System.Drawing.Size(987, 387);
            this.Assets.TabIndex = 4;
            this.Assets.Text = "Assets";
            this.Assets.UseVisualStyleBackColor = true;
            // 
            // Misilinious
            // 
            this.Misilinious.Location = new System.Drawing.Point(4, 22);
            this.Misilinious.Name = "Misilinious";
            this.Misilinious.Size = new System.Drawing.Size(987, 387);
            this.Misilinious.TabIndex = 5;
            this.Misilinious.Text = "Misilinious";
            this.Misilinious.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1031, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.AmazonReplay);
            this.Controls.Add(this.AmazonServer);
            this.Controls.Add(this.AmazonConsole);
            this.Name = "Form1";
            this.Text = "File Configurator";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void ClearAllControl()
        {

        }

        #endregion

        private System.Windows.Forms.RadioButton AmazonConsole;
        private System.Windows.Forms.RadioButton AmazonServer;
        private System.Windows.Forms.RadioButton AmazonReplay;
        private System.Windows.Forms.TabPage Screen;
        private System.Windows.Forms.TabPage Disco;
        private System.Windows.Forms.TabPage Network;
        private System.Windows.Forms.TabPage DataBase;
        private System.Windows.Forms.TabPage Assets;
        private System.Windows.Forms.TabPage Misilinious;
        public System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Button button1;
    }
}

