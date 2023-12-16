using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices.SOLID.D.CodeSmell
{
    /// <summary>
    /// High level module should not depend on low level modules but both should depend of abstractions
    /// </summary>
    // high level module
    internal class NotificationService
    {
        // low Level modules that contain concrete implementation
        private readonly EmailSender _emailSender; 
        private readonly SmsSender _smsSender;

        public NotificationService()
        {
            _emailSender = new EmailSender();
            _smsSender = new SmsSender();
        }

        private void SendEmailNotification ()
        {
            // implementation
            _emailSender.SendEmailNotification();
        }

        void SendSmsNotification()
        {
            // implementation
            _smsSender.SendEmailNotification();
        }
    }
}
