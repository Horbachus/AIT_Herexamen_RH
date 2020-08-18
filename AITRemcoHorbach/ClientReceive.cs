
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AITRemcoHorbach
{
    public delegate void ReceviedMessage(string sender, string message);
    public delegate void GotNames(object sender, List<string> names);

    class ReceiveClient : ISendChatServiceCallback
    {
        public event ReceviedMessage ReceiveMsg;
        public event GotNames NewNames;

        InstanceContext inst = null;
        SendChatServiceClient chatClient = null;

        public void Start(ReceiveClient receiveClient, string name)
        {
            inst = new InstanceContext(receiveClient);
            chatClient = new SendChatServiceClient(inst);
            chatClient.Start(name);
        }

        public void SendMessage(string message, string sender, string receiver)
        {
            chatClient.SendMessage(message, sender, receiver);
        }

        public void Stop(string name)
        {
            chatClient.Stop(name);
        }

        void ISendChatServiceCallback.ReceiveMessage(string message, string receiver)
        {
            ReceiveMsg?.Invoke(receiver, message);
        }

        public void SendNames(string[] names)
        {
            NewNames?.Invoke(this, names.ToList());
        }
    }
}
