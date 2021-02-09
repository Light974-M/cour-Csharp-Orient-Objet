using System;

namespace DM
{
    class Cars
    {
        private string _ownerName;
        
        public Cars(string ownerName)
        {
            _ownerName = ownerName;
        }

        public override string ToString()
        {
            return _ownerName + "'s car";
        }
    }
}