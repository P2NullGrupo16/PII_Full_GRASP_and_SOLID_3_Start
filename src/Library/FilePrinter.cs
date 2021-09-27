using System;
using System.IO;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public void PrintTicket(Recipe recipe)
        {
            File.WriteAllText("Impresión_de_Receta.txt", recipe.GetTextToPrint());
        }
    }
}