using System;
using System.Collections;
using System.Collections.Generic;

namespace DataBases
{
    public class CryptoToken
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }

        public virtual ICollection<Exchange> Exchanges { get; set; }
    }
}
