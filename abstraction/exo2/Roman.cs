using System;

namespace exo2
{
    class Roman : Livre
    {
        protected string _contestPrices;

        public Roman(string contestPrices)
        {
            _contestPrices = contestPrices;
        }
    }
}