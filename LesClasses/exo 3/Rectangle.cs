using System;

namespace exo_3
{
    class Rectangle
    {
        private int _hauteur;
        private int _largeur;

        private int _positionX;
        private int _positionY;


        public Rectangle()
        {
            
        }
        public Rectangle(int hauteur, int largeur, int positionX, int positionY)
        {
            _hauteur = hauteur;
            _largeur = largeur;
            _positionX = positionX;
            _positionY = positionY;
        }

        public double Aire()
        {
            double aire;
            aire = _hauteur * _largeur;
            return aire;
        }

        public override string ToString()
        {
            return $"dimensions : {_hauteur}*{_largeur} \nposition : ({_positionX},{_positionY})";
        }
    }
}