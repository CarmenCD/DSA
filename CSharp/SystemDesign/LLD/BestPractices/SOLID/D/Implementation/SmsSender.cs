namespace BestPractices.SOLID.D.Implementation
{
    internal class SmsSender : INotificationSender
    {
        public void SendNotification()
        {
            Console.WriteLine("Send SMS notification");
        }
    }
}