using System;

namespace DM
{
    public abstract class Vehicle
    {
        //initialisation de la plupart des arguments.
        protected string _immatriculation;
        public int _maxSpeed;
        protected int _emptyMass;
        protected double _charge;
        protected int _maxCharge;

        //initialisation de la fonction abstract caluclant la masse total
        protected abstract double TotalMass(double charge, int maxCharge);
    }
}