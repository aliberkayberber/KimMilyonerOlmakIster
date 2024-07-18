
using System;

namespace KimMilyonerOlmakIster
{
    class Program
    {
        static void Main(string[] args) 
        {
            byte trueReply = 0;
            byte falseReply =0;
            System.Console.WriteLine("Kim milyoner olmak ister'e hoş geldiniz");
            System.Console.WriteLine("");
            System.Console.WriteLine("1) Türkiye'nin başkenti hangisidir ?");
            System.Console.WriteLine("");
            System.Console.WriteLine("a) Istanbul  b) Ankara");
            System.Console.WriteLine("");
            System.Console.Write("Cevabınız: ");
            System.Console.WriteLine("");
            string reply1 = Console.ReadLine();
            reply1 = reply1.ToLower(); // küçük harfe çeviriliyor

            if (reply1 == "b")
            {   
                System.Console.WriteLine("Doğru Cevap tebrikler !");
                trueReply++;
            }
            else
            {
                falseReply++;
                System.Console.WriteLine("Yanlış cevap !");
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("2) Mona Lisa'yı kim çizdi?");
            System.Console.WriteLine("");
            System.Console.WriteLine("a) Leonardo da Vinci  b)Bedri Baykam");
            System.Console.WriteLine("");
            System.Console.Write("Cevabınız: ");
            string reply2 = Console.ReadLine();
            reply2 = reply2.ToLower(); // küçük harfe çeviriliyor

            if (reply2 == "a")
            {
                System.Console.WriteLine("Doğru cevap tebrikler! ");
                trueReply++;
            }
            else
            {
                System.Console.WriteLine("Yanlış cevap!");
                falseReply++;
            }
            
            if(trueReply == 1 && falseReply ==1)  // Kazanama ihtimali var mı diye bakıyorum
            {
                System.Console.WriteLine("3) '' 1984'' olarak bilinen ünlü romanın yazarı kimdir? ");
                System.Console.WriteLine("");
                System.Console.WriteLine("a) George Orwell  b) Sait Faik Abasıyanık");
                System.Console.WriteLine("");
                System.Console.Write("Cevabınız: ");
                string reply3 = Console.ReadLine();
                reply3 = reply3.ToLower(); // küçük harfe çeviriliyor

                if (reply3 == "a")
                {
                    System.Console.WriteLine("Tebrikler doğru cevap!");
                    trueReply++;
                }
                else
                {
                    System.Console.WriteLine("Yanlış cevap");
                    falseReply++;
                }
            }

            if (trueReply == 2)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("Tebrikler büyük ödülü kazandınız!");
            }
            else 
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("Tekrar deneyiniz!!!");
            }
        }
    }
}
