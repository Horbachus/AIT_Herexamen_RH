using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITRemcoHorbach
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ChatService.ISendChatService", CallbackContract = typeof(AITRemcoHorbach.ISendChatServiceCallback))]
    public interface ISendChatService
    {

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/ISendChatService/SendMessage")]
        void SendMessage(string message, string sender, string receiver);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/ISendChatService/Start")]
        void Start(string Name);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/ISendChatService/Stop")]
        void Stop(string Name);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISendChatServiceCallback
    {

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/ISendChatService/ReceiveMessage")]
        void ReceiveMessage(string message, string receiver);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/ISendChatService/SendNames")]
        void SendNames(string[] names);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISendChatServiceChannel : AITRemcoHorbach.ISendChatService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SendChatServiceClient : System.ServiceModel.DuplexClientBase<AITRemcoHorbach.ISendChatService>, AITRemcoHorbach.ISendChatService
    {

        public SendChatServiceClient(System.ServiceModel.InstanceContext callbackInstance) :
                base(callbackInstance)
        {
        }

        public SendChatServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) :
                base(callbackInstance, endpointConfigurationName)
        {
        }

        public SendChatServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) :
                base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }

        public SendChatServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }

        public SendChatServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(callbackInstance, binding, remoteAddress)
        {
        }

        public void SendMessage(string message, string sender, string receiver)
        {
            base.Channel.SendMessage(message, sender, receiver);
        }

        public void Start(string Name)
        {
            base.Channel.Start(Name);
        }

        public void Stop(string Name)
        {
            base.Channel.Stop(Name);
        }
    }
}
