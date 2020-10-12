using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationPatterneNetCoreSample.Entity
{
    public class Person :Notifiable 
    {
        public Person(string name, string email)
        {
            Name = name;
            Email = email;

            AddNotifications(new ValidationContract()
                .HasMinLen(Name, 3, "Name", "Name property must have at least 3 chars")
                .HasMaxLen(Name,10, "Name", "Name must Not exceed 10 chars")
                .IsEmail(Email, Email, "Email is not valid")


                );
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}
