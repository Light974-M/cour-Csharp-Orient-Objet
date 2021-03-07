using System;

namespace exo2
{
    class Livre : Document
    {
        protected string _autor;
        protected int _pageNumber;

        public Livre(string autor, int pageNumber)
        {
            _autor = autor;
            _pageNumber = pageNumber;
        }
    }
}