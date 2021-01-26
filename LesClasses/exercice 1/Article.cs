using System;

namespace exercice_1
{
    public class Article
    {
        int numeroDeReference;
        string name;
        double prixAchat;
        double prixVente;

        public Article(int numeroDeReference, string name, double prixAchat, double prixVente)
        {
            this.numeroDeReference = numeroDeReference;
            this.name = name;
            this.prixAchat = prixAchat;
            this.prixVente = prixVente;
        }

        public static string CodeBarre(int numeroDeReference, string name, double prixAchat, double prixVente)
        {
            string codeBarre;

            codeBarre = numeroDeReference.ToString() + name + prixAchat.ToString() + prixVente.ToString();

            return codeBarre;
        }
    }
}