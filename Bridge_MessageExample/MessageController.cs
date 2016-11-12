namespace DesignPatterns.Bridge_MessageExample
{
    public class MessageController
    {
        IMessage Message { get; set; }

        public void SetMessageType(MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.SMS:
                    Message = new SMSMessage();
                    break;
                case MessageType.Email:
                    Message = new EmailMessage();
                    break;
            }
        }

        public void SendMessage(string to, string message)
        {
            Message.SendMessage(to, message);
        }
    }
}
