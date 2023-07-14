using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExamenPractico
{
    public class MayoriaEdad
    {
        public static string MayorDeEdad(int edad)
        {
            if (edad < 18)
            {
                
                return "Es menor de edad";

            }
            else
            {
                return "Es mayor de edad";
            }
            
        }
         
       

        
        

    }
}                            
   
