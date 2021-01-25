using System;

namespace exo2
{
    unsafe class Program
    {
        static FamilyAccount account;
        public unsafe static void Main(string[] args)
        {
            FamilyAccount commetuveux = new FamilyAccount();
        }

        public unsafe struct FamilyAccount
        {
            public float amount;
        }

        public unsafe struct MemberAccount
        {
            private FamilyAccount* account;

            
        }

        public MemberAccount()
        {

        }
    }
}
