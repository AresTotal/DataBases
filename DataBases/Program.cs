 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBases
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDBContext())
            {
                var cryptoToken = new CryptoToken()
                {
                    Name = "Bitcoin",
                    Year = 2012
                };

                var cryptoToken2 = new CryptoToken()
                {
                    Name = "Ethereum"
                };

                context.CryptoTokens.Add(cryptoToken);
                context.CryptoTokens.Add(cryptoToken2);

                var cryptoTokens = new List<CryptoToken>
                {
                    new CryptoToken(){Name = "Monero", Id = cryptoToken2.Id},
                };

                
                context.SaveChanges();

                Console.WriteLine($"id: {cryptoToken.Id}, name: {cryptoToken.Name}, year: {cryptoToken.Year}");

            }
        }
    }
}
