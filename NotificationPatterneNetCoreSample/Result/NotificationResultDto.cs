using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationPatterneNetCoreSample.Result
{
    public class NotificationResultDto
    {
        public NotificationResultDto(bool sucesss, string message, object data)
        {
            Sucesss = sucesss;
            Message = message;
            Data = data;
        }

        public bool Sucesss { get; private set; }
        public string Message { get; private set; }
        public object Data { get; private set; }

    }
}
