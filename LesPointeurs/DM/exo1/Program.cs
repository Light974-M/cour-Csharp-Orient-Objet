using System;
//dans le namespace exo1.
namespace exo1
{
    /*
    dans la classe program
        la classe est mise en unsafe pour pouvoir utiliser.
    */
    unsafe class Program
    {
        //dans le champ main.
        static void Main(string[] args)
        {
            //déclaration des variables char caractere1 et caractere 2, assignation de la valeur '0" à caractere1 et 'A' à caractere2.
            char caractere1 = 'O';
            char caractere2 = 'A';

            //déclaration des variables pointeur de type char* caractere1Pointer et caractere2Pointer, le premier pointeur pointe sur caractere1 et le deuxieme sur caractere2.
            char* caractere1Pointer = &caractere1;
            char* caractere2Pointer = &caractere2;

            /*
            appelle de la fonction unsafe static de type void FirstCharIntoSecond prenant en argument deux variables de type char caractere1Pointer caractere2Pointer.
                assignation des arguments de la fonction FirstCharIntoSecond aux variables de type char* caractere1Pointer et caractere2Pointer.
            */
            FirstCharIntoSecond(caractere1Pointer, caractere2Pointer);

            /*
            affichage des valeurs pointé par caractere1Pointer et caractere2Pointer.
            */
            Console.WriteLine($"{nameof(caractere1Pointer)} : {*caractere1Pointer} \n{nameof(caractere2Pointer)} : {*caractere2Pointer}");
        }

        /*
        enrée dans la fonction unsafe static de type void FirstCharIntoSecond prenant en argument deux variables de type char* caractere1Pointer et caractere2Pointer.
            la fonction affecte a la valeur pointé par caractere2Pointer la valeur pointé par caractere1Pointer.
            la fonction est unsafe pour pouvoir utiliser les pointeurs.
            la fonction est static pour pouvoir l'appeller dans le main.
            la fonction est de type void car elle ne retourne rien.
        */
        unsafe static void FirstCharIntoSecond(char* caractere1Pointer, char* caractere2Pointer)
        {
            //affectation de la valeur pointé par caractere1Pointer à la valeur pointé par caractere2Pointer.
            *caractere2Pointer = *caractere1Pointer;
        }
    }
}
