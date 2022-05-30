using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    internal class QandA
    {


        /* ***** Q1: Hur fungerar stacken och heapen? *****
        STACKEN 
        skulle kunna liknas vid ett arbetsminne: här hålls alla trådar som utförs (processerna för metoder som utförs och alla anrop)
        Det är som ett tillfälligt minne, ofta beskrivet som lådor staplade på varandra där bara den översta lådan är åtkomlig. När en "låda" är avklarad 
        så hivas den och nästa låda blir åtkomlig. STACKEN städas så att säga direkt och ingenting sparas här. Här sparas också alla POINTERS eller adresser 
        till REFERENSTYPER, alltså behöver vi "gå igenom" STACKEN för att komma åt våra REFERENSTYPER (som ALLTID finns i HEAPEN). 

        HEAPEN
        är ett långtidsminne där "saker" endast försvinner när städnig genomförs, alltså när GARBAGE COLLECTORN sätter igång. Här sparas "saker" som vi 
        kan komma åt "direkt". Datan/Informationen/Sakerna är direktåtkomliga, som tvätt utspridd på en säng eller där "saker" står på rad i en hylla, 
        är synliga och bara att plocka ner -utan någon speciell ordning.

        **********************************************************************************************************************************************************

         ***** Q2: Vad är Value Types repsektive Reference Types och vad skiljer dem åt? *****
        REFERENCETYPES
        sparas alltid på HEAPEN och har alltid en POINTER till den på STACKEN, vi måste alltså gå igenom STACKEN för att komma åt den. När vi hanterar REFERENCETYPES
        hanterar alltså inte själva "saken" utan POINTERN på STACKEN
        Exempel på REFERENCETYPES: Klass
        (Ärver av System.Object)

        VALUETYPES (och POINTERS)
        Finns alltid där de är skapade, antingen på STACKEN eller på HEAPEN. När vi handterar VALUETYPES använder vi oss av "saken" direkt, som hårddata.
        När VALUETYPES deklareras i en metod (som processas på STACKEN) så skapas den på STACKEN.
        När en VALUETYPE deklareras utanför en metod, men i en REFERENSETYPE (Klass tex) så skapas den inne i REFERENSTYPEN på HEAPEN.
        Exempel på VALUETYPES: Simple Types, Struct Types
        (Ärver av System.ValueTypes)

        **********************************************************************************************************************************************************
        
          ***** Q3: Metodernas olika utfall. *****
          *********** A: Metoden som returnerar 3 ***********
          
        
        public int ReturnValue()  => Metod vilket gör att Minnesutrymmet som används under processen är STACKEN
            {  
                 int x = new int(); => int är objekt av typen VALUETYPE (döpt till x). Då den skapas på STACKEN sparas den på STACKEN
                 x = 3;  => Eftersom x är en VALUETYPE betyder = att vi sätter innehållet i objeketet till 3 "Hårdkodat på själva objektet"
                 int y = new int();  => Här skapas ännu ett objekt (döpt till y) av VALUETYPE på STACKEN
                 y = x; => Här vi sätter innehållet i objekt(y) till samma som objekt(x) är. Alltså två objekt som båda innehåller 3. Vi har alltså två stycken 3:or      
                 y = 4; => Här sätter vi innehållet i objek(y) till 4.           
                 return x;  => Vi har inte gjort om objekt(x), utan har ett objekt(y) som är 4 och ett objekt(x) som är 3. Returen blir alltså 3.
            }  
          

           *********** B: Metoden som returnerar 4 ***********


            public int ReturnValue2()   => Metod vilket gör att Minnesutrymmet som används är STACKEN
            {  
                  MyInt x = new MyInt();  => Här finns det en klass i bakgrunden (MyInt)vilket gör objektet till en REFERENSTYPE. Objektet, objekt(x), sparas på HEAPEN, med POINTERN referens(x) kopplad till den på STACKEN
                  x.MyValue = 3;       => Genom att använda POINTERN ref(x) till objekt(x) på HEAPEN sätter vi innehållet för objekt(x) till 3
                  MyInt y = new MyInt();  => Här skapas ännu ett objekt(y) som sparas på HEAPEN med POINTERN ref(y) kopplad till sig på STACKEN
                  y = x;                 => Här sätts POINTERN ref(y) att peka till objekt(x). De två referenserna pekar nu till samma objekt(x). Inget MyValue är satt på y. 
                  y.MyValue = 4;       =>  Genom att använda POINTERN ref(y) som också nu pekar mot objekt(x) sätts innehållet till 4          
                  return x.MyValue;     => Ref(x) pekar mor objekt(x) som nu är 4
             }
           *
          *  
          *   **********************************************************************************************************************************************************
          *   Övn 1.2: När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
          *         När 4 element lags till
          *   1.3 Med hur mycket ökar kapaciteten?
          *         Den dubblerar sig 
          *   1.4  
          *   1.5 Nej, listan minskas inte
          *   1.6 När man behöver spara minne
          *   
          *   
          *   
         * */
    }
}
