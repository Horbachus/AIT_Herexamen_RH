using ChatroomServers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatroomServers
{
    public partial class ChatroomServer : Form
    {
        bool btnStart;
        ServiceHost host;
        ChatService chatService = new ChatService();


        public ChatroomServer()
        {
            InitializeComponent();
            btnStart = true;
        }

        void listOfUsers(List<string> names, object sender)
        {
            UserList.Items.Clear();
            foreach (string user in names)
            {
                UserList.Items.Add("User " + user + " connected to the server");
            }
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                if (btnStart)
                {
                    host = new ServiceHost(typeof(ChatService));
                    host.Open();
                    button1.Text = "Stop server";
                    ChatService.ChatListOfNames += new ListOfUsers(listOfUsers);
                }
                else
                {
                    chatService.Close();
                    host.Close();
                    button1.Text = "Start server";
                }

                btnStart = !btnStart;
            }
        }
    }
}
