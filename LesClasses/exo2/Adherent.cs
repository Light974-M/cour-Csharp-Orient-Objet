using System;

namespace exo2
{
    class Adherent
    {
        private string _memberNum;
        private string _name;

        public Adherent()
        {
            this._name = "anonyme";

            this._memberNum = "0";

        }

        public Adherent(string _name)
        {
            string _memberNum = "A83400D";

            char[] _nameArray;

            _nameArray = _name.ToCharArray();
            _memberNum += "_";
            for(int i = 0; i < _nameArray.Length; i++)
            {
                _memberNum +=(Convert.ToInt32(_nameArray[i])).ToString();
                _memberNum += "_";
            }
            _memberNum += "N";

            var rand = new Random();

            for(int i=0; i< 15; i++)
            {
                _memberNum += rand.Next(10).ToString(); 
            }
            _memberNum += "_";
            
            this._memberNum = _memberNum;
            this._name = _name;
            Console.WriteLine($"vous avez appeller le membre1 : \nnom : {_name} \nnuméro de suivi : {_memberNum}");
            
        }
    }
}