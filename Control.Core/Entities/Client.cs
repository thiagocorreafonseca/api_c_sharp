using System;

namespace Control.Core.Entities
{
    public class Client
    {
        public int Id { get; private set; }
        public string CompanyName { get; private set; }
        public string TradingName { get; private set; }
        public string CPFCNPJ { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public Boolean Active { get; private set; }

        public Client(string companyName, string tradingName, string cpfcnpj)
        {
            CompanyName = companyName;
            TradingName = tradingName;
            CPFCNPJ = cpfcnpj;
            CreatedAt = DateTime.Now;
            Active = false;
        }
    }
}
