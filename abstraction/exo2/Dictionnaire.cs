using System;

namespace exo2
{
    class Dictionnaire : Document
    {
        protected string _language;

        public Dictionnaire(string language)
        {
            _language = language;
        }
    }
}