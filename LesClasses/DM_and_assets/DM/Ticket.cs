using System;

namespace DM
{
    class Ticket
    {
        private Cars _carReference;

        private DateTime _ticketBought = new DateTime(2021, 2, 3, 15, 4, 0);

        public Ticket(Cars carReference, DateTime ticketBought)
        {
            _carReference = carReference;
            _ticketBought = ticketBought;
        }


    }
}