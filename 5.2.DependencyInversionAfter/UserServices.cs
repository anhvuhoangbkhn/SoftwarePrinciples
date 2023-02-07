using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2.DependencyInversionAfter
{
    internal class UserServices
    {
        private readonly ISmsNotification _smsNotification;
        public UserServices(ISmsNotification smsNotification)
        {
            _smsNotification = smsNotification;
        }

        public void Register()
        {
            //ToDo Register
            _smsNotification.SendMessage();
        }
    }
}
