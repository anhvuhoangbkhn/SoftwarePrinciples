using System;
namespace _4._1.InterfaceSegregationBefore
{
    public class AmazonServices : ISendMessage
    {
        public void SendFromAmazon()
        {
            throw new NotImplementedException();
        }

        public void SendFromAzure()
        {
            throw new NotImplementedException();
        }
    }
}
