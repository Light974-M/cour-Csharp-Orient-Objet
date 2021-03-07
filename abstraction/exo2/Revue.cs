using System;

namespace exo2
{
    class Revue : Document
    {
        protected int _month;
        protected int _year;

        public Revue(int month, int year)
        {
            _month = month;
            _year = year;
        }
    }
}