using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace MenuConsolaInteractivo
{
    public class InterfazInicio
    {
        public void Start()
        {
            string prompt = "Bienvenido al programa";
            string promp2 = "Bienvenido al subMenu";
            string[] options = {"Play","About","Exit"};
            string[] subOptions = {"Cargar un cliente","Borrar un cliente","Editar un cliente", "Salir"};
            Menu mainMenu = new Menu(prompt,options);
            Menu subMenu = new Menu(promp2,subOptions);
            int SelectedIndex = mainMenu.Run();
            int item2;
            if(SelectedIndex == 1)
                item2 = subMenu.Run();
            WriteLine("Presione una tecla para salir...");
        }
    }
}