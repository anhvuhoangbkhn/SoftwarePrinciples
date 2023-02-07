using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2.InterfaceSegregationAfter
{
    public class FullSendMessageServices : ISendMessageFromAzure, ISendMessageFromAmazon
    {
        public void SendMessageFromAmazon()
        {
            //ToDo
        }

        public void SendMessageFromAzure()
        {
            //ToDo
        }
    }
}
