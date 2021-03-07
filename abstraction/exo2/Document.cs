using System;

namespace exo2
{
    class Document
    {
        protected int _referenceNumber;
        protected string _title; 

        public Document(int referenceNumber, string title)
        {
            _referenceNumber = referenceNumber;
            _title = title;
        }
    }
}