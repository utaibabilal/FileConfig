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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.Screen = new System.Windows.Forms.TabPage();
            this.Disco = new System.Windows.Forms.TabPage();
            this.Network = new System.Windows.Forms.TabPage();
            this.DataBase = new System.Windows.Forms.TabPage();
            this.Assets = new System.Windows.Forms.TabPage();
            this.Misilinious = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.tbTagName = new System.Windows.Forms.TextBox();
            this.btnImg = new System.Windows.Forms.Button();
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
            this.button1.Location = new System.Drawing.Point(642, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add value";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(816, 27);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 20);
            this.tbValue.TabIndex = 6;
            // 
            // tbTagName
            // 
            this.tbTagName.Location = new System.Drawing.Point(925, 28);
            this.tbTagName.Name = "tbTagName";
            this.tbTagName.Size = new System.Drawing.Size(84, 20);
            this.tbTagName.TabIndex = 7;
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(459, 27);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(35, 23);
            this.btnImg.TabIndex = 8;
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1031, 474);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.tbTagName);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlMain);
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
        private System.Windows.Forms.TabPage Screen;
        private System.Windows.Forms.TabPage Disco;
        private System.Windows.Forms.TabPage Network;
        private System.Windows.Forms.TabPage DataBase;
        private System.Windows.Forms.TabPage Assets;
        private System.Windows.Forms.TabPage Misilinious;
        public System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.TextBox tbTagName;
        private System.Windows.Forms.Button btnImg;
    }
}

