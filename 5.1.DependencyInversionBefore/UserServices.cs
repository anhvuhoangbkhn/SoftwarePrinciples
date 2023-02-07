namespace _5._1.DependencyInversionBefore
{
    public class UserServices
    {
        private readonly SmsNotification _smsNotification;

        public UserServices()
        {
            _smsNotification = new SmsNotification();
        }
        public void Register()
        {
            //ToDo Register

            _smsNotification.SendMessage();
        }
    }
}
