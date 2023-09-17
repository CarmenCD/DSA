namespace BestPractices.SOLID.D.Implementation
{
    /// <summary>
    /// High level module should not depend on low level modules but both should depend of abstractions
    /// </summary>
    // high level module
    internal class NotificationService
    {
        private INotificationSender _notificationSender; //lowLevel modules

        public NotificationService(INotificationSender notificationSender)
        {
            _notificationSender = notificationSender;
        }
    }
}
