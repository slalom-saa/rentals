using System;
using System.Collections.Generic;
using System.Text;
using Slalom.Stacks.Messaging;

namespace Slalom.Rentals.Application.Integration
{
    [Request("notifications/send")]
    public class SendNotification
    {
        public string Email { get; }

        public string Message { get; }

        public SendNotification(string email, string message)
        {
            this.Email = email;
            this.Message = message;
        }
    }
}
