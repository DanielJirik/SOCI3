using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class Animation
    {   

        public Animation() 
        { 
            
        }

        public enum Types 
        { 
            Var, 
            Con, 
            Switch,
            Cycle,
            Process, 
            Output,
            Start
        }

        public void ImagesForBlocks(Types orders) 
        { 
            //foreach ((int, Types) i in Panel) 
            //{ 
                
            //}
            //zjištění které bloky jsou propojeny a následně přiřadit příslušný tmavý obrázek
        }

        public async void Delays(int pause)
        { 
            //asynchronní metoda pro pauzu
            //potřebná asynchronní funkce pro run možná
            //po vyhodnocení bloků by se bloky vrátili do původní podoby
        }
    }
}
