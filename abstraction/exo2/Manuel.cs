using System;

namespace exo2
{
    class Manuel : Livre
    {
        protected int _scholarLevel;
        protected string _scholarLevelRating;

        public Manuel(int scholarLevel, string scholarLevelRating)
        {
            _scholarLevel = scholarLevel;
            _scholarLevelRating = scholarLevelRating;
        }
    }
}