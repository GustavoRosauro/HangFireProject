using HangFireJobs.Core.Interfaces;
using System;

namespace HangFireJobs.Core
{
    public class Services:IServices
    {
        public void EscreverMensagem()
        {
            Console.WriteLine("Estou escrevendo....");
        }
    }
}
