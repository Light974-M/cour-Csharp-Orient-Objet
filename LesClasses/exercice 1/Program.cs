using System;

namespace exercice_1
{

    class program
    {
        static void Main(string[] args)
        {
            Article RTX_2080 = new Article(01, "RTX_2080", 239.70, 798.99);
            Stock stock = new Stock(100);
            stock.AddArticle(RTX_2080);
        }
    }
}
