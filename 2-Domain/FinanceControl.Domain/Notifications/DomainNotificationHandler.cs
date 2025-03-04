﻿
using FinanceControl.Domain._2._1_Interface;

namespace FinanceControl.Domain.Notifications
{
    public class DomainNotificationHandler : IDomainNotificationHandler
    {
        private List<DomainNotification> _notifications;
        public DomainNotificationHandler() 
        {
            _notifications = new List<DomainNotification>();
        }
        public List<DomainNotification> GetNotifications() 
        {
            return _notifications;
        }
        public void Handle(DomainNotification notification)
        {
            _notifications.Add(notification);
        }

        public void Handle(string notification) 
        {
            _notifications.Add(new DomainNotification(notification));
        }

        public bool HasNotifications()
        {
            return _notifications.Any();
        }


    }
}
