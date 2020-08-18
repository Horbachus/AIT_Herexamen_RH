namespace ChatroomServers
{
    partial class ChatroomServer
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
            this.UserList = new System.Windows.Forms.ListBox();
            this.exitServer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(0, 0);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(425, 173);
            this.UserList.TabIndex = 0;
            // 
            // exitServer
            // 
            this.exitServer.Location = new System.Drawing.Point(296, 183);
            this.exitServer.Name = "exitServer";
            this.exitServer.Size = new System.Drawing.Size(117, 55);
            this.exitServer.TabIndex = 1;
            this.exitServer.Text = "Exit Server";
            this.exitServer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "StartServer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChatroomServer
            // 
            this.ClientSize = new System.Drawing.Size(425, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitServer);
            this.Controls.Add(this.UserList);
            this.Name = "ChatroomServer";
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Button exitServer;
        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.Button button1;
    }
}

