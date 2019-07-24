namespace NanikApplication
{
    public class AshxatavardziXndirBard
    {
         public static void ashxatavardzBard()
        {
            System.Console.WriteLine("Naniki if ov xndir@");
            
            
            // Im ashxatavardz@ amsekan
            int ashxatavardz = 1000;
            
            
            // Im caxser@ ansekan
            int luysiVardz = 20;
            int gaziVardz = 100;
            
            // ete ayl@ntranq e, @ntrum enq uteliq@ 
            int erexeqinSHor = 500;
            int uteliq = 500;
            
            //ete amen inchic heto gumar mnum e anum enq
            int indzBaner = 300;
            int chnaxatesvacCaxser = 500;
            
            
            // mekel amsva verji koxmer@ mi hat tuyn shor tesa uzum em arnem, bayc chgitem motis pox@ kheriqi te che
            int tuynSHor = 100;


            if (ashxatavardz >= luysiVardz)
            {
                System.Console.WriteLine("Ashxatavardzs minchev lusi vardz@ mucel@: " + ashxatavardz);
                ashxatavardz = ashxatavardz - luysiVardz;
                System.Console.WriteLine("Ashxatavardzs lusi vardz@ muceluc heto: " + ashxatavardz);
            }
            else
            {
                System.Console.WriteLine("Ashxatavardzs chheriqec vor luysi vardz@ muceinq: " + ashxatavardz);
            }
            
            
            if (ashxatavardz >= gaziVardz)
            {
                System.Console.WriteLine("Ashxatavardzs minchev gazi vardz@ mucel@: " + ashxatavardz);
                ashxatavardz = ashxatavardz - gaziVardz;
                System.Console.WriteLine("Ashxatavardzs gazi vardz@ muceluc heto: " + ashxatavardz);
            }
            else
            {
                System.Console.WriteLine("Ashxatavardzs chheriqec vor gazi vardz@ muceinq: " + ashxatavardz);
            }
            
            
            if (ashxatavardz >= uteliq + erexeqinSHor)
            {
                System.Console.WriteLine("Ashxatavard@ heriqec ham uteliqi ham shori: " + ashxatavardz);
                ashxatavardz = ashxatavardz - uteliq;
                ashxatavardz = ashxatavardz - erexeqinSHor;
                System.Console.WriteLine("Ashxatavardzs ham shor ham uteliq arneluc heto: " + ashxatavardz);
            }
            else if (ashxatavardz >= uteliq)
            {
                System.Console.WriteLine("Ashxatavardzs heriqec menak utiliqi: " + ashxatavardz);
                ashxatavardz = ashxatavardz - uteliq;
                System.Console.WriteLine("Ashxatavardzs uteliq arneluc heto: " + ashxatavardz);
            }
            else
            {
                System.Console.WriteLine("Ashxatavardzs chheriqec voch uteliqi voch shori: " + ashxatavardz);
            }
            
            if (ashxatavardz >= indzBaner)
            {
                System.Console.WriteLine("Ashxatavardzs minchev indz baner arnel@: " + ashxatavardz);
                ashxatavardz = ashxatavardz - indzBaner;
                System.Console.WriteLine("Ashxatavardzs indz baner arneluc heto: " + ashxatavardz);
            }
            else
            {
                System.Console.WriteLine("Ashxatavardzs chheriqec vor indz baner arnenq: " + ashxatavardz);
            }
            
            if (ashxatavardz >= chnaxatesvacCaxser)
            {
                System.Console.WriteLine("Ashxatavardzs minchev chnaxatesvac caxser@: " + ashxatavardz);
                ashxatavardz = ashxatavardz - chnaxatesvacCaxser;
                System.Console.WriteLine("Ashxatavardzs chnaxatesvac saxser aneluc heto: " + ashxatavardz);
            }
            else
            {
                System.Console.WriteLine("Ashxatavardzs chheriqec vor chnaxatesvac caxser anenq: " + ashxatavardz);
            }
            
            if (ashxatavardz >= tuynSHor)
            {
                System.Console.WriteLine("Ashxatavardzs minchev tuyn shor arnel@: " + ashxatavardz);
                ashxatavardz = ashxatavardz - tuynSHor;
                System.Console.WriteLine("Ashxatavardzs tuyn shor arneluc heto: " + ashxatavardz);
            }
            else
            {
                System.Console.WriteLine("Ashxatavardzs chheriqec vor tuyn shor arnenq: " + ashxatavardz);
            }
        }
    }
}