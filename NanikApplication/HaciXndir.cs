using System.Diagnostics.Eventing.Reader;

namespace NanikApplication
{
    public class HaciXndir 
    {
        public static void HaciXndir1()
        
        {
            System.Console.WriteLine("Haci Xndir");
            
            // gnel fgransyakan hac
            int hac = 0;
            
            //gnel lavash ete chka fransyakan hac 
            int lavash = 0;
            
            //gnel puri ete chka voch fransyakan ,voch el lavash
            int puri = 30;

            if (hac == 0)
            {
                System.Console.WriteLine("Grox@ tani hac chka");
            }
            else
            {
                System.Console.WriteLine("Gnel lavash, hac chlinelu depqum");
            }

            if (lavash != 0)
            {
                System.Console.WriteLine("Gnel lavash hac chlinelu depqum");
                lavash = lavash - hac;
                System.Console.WriteLine("Gnel lavash ");
            }
            else
            {
                System.Console.WriteLine("Gnel lavash");
            }

            if (puri != 0)
            {
                System.Console.WriteLine("Gnel puri ,ete chka voch hac voch lavash");
                puri = puri - lavash;
                System.Console.WriteLine("Gnela puri");
            }
            else 

            {
                System.Console.WriteLine("Gnel puri ete chka ");
            }
        }
    }
    
    
    
    
    
    







        




















































}





        