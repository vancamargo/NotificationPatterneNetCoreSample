using FluentValidator;
using NotificationPatterneNetCoreSample.Entity;
using NotificationPatterneNetCoreSample.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationPatterneNetCoreSample
{
    public class Verifier :Notifiable
    {
        public NotificationResultDto Execute()
        {
            var person = new Person("vanessa", "vanessa@gmail.com.br");
            return Verify(person);
        }

        private NotificationResultDto Verify(Person person)
        {

            //Valides entity
            AddNotifications(person.Notifications);
            if (Invalid)
            {
                return new NotificationResultDto(
                    false,
                    "Please valide following fields:",
                    Notifications);
            }
            return new NotificationResultDto(
                    true,
                    "Validation sucesss",
                    null);
        }
    }
}
