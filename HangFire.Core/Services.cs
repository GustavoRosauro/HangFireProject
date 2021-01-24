using HangFire.API.Interfaces;
using System;

namespace HangFire.Core
{
    public class Services:IServices
    {
        public void EscreverMensagem()
        {
            Console.WriteLine("Escrever mensagem");
        }        
    }
}
