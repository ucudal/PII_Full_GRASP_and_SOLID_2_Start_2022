using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter {

        public static void Printer (Recipe recipe) {
            Console.WriteLine(recipe.BuildRecipe());
        }

        //Utilizo el patron SRP para dejarle a Recipe unicamente responsabilidades que tengan que ver con
        //la receta misma como el armado de la presentacion de la receta para luego que la clase printer
        //sea el unico encargado en llevar a cabo la impresion de esa presentacion
    }
    
}