namespace BestPractices.SOLID.D.Implementation
{
    internal class EmailSender : INotificationSender
    {
        public void SendNotification()
        {
            Console.WriteLine("Send email notification");
        }
    }
}
