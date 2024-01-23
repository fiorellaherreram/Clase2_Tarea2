using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TipoEmp, Ced, CantH; 
            Decimal Precio, SalOrdinario, Aumento = 0, SalBruto = 0, Deduccion = 0, SalNeto = 0;
            string Nombre, Empleado = "null";

            Console.WriteLine("Digite su nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Digite su cedula:");
            Ced = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el numero de acuerdo a su tipo de empleado: \n 1. Operario \n 2. Tecnico \n 3. Profesional");
            TipoEmp = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de horas trabajadas:");
            CantH = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio por hora:");
            Precio = int.Parse(Console.ReadLine());

            SalOrdinario = CantH * Precio;

            switch (TipoEmp)
            {
                case 1:
                    Empleado = "1 - Operario";
                    Aumento = SalOrdinario * 0.15m;
                    SalBruto = SalOrdinario + Aumento;
                    break;
                case 2:
                    Empleado = "2 - Tecnico";
                    Aumento = SalOrdinario * 0.10m;
                    SalBruto = SalOrdinario + Aumento;
                    break;
                case 3:
                    Empleado = "3 - Profesional";
                    Aumento = SalOrdinario * 0.05m;
                    SalBruto = SalOrdinario + Aumento;
                    break;
                        }

            Deduccion = SalBruto * 0.0917m;
            SalNeto = SalBruto - Deduccion;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Nombre: " + Nombre + "\nCedula: " + Ced + "\nTipo de Empleado: " + Empleado + "\nCantidad de Horas Trabajadas: " + CantH +
                "\nPrecio por Hora: " + Precio + "\nSalario Ordinario: " + SalOrdinario + "\nAumento: " + Aumento + "\nSalario Bruto: " + SalBruto + 
                "\nDeduccion CCSS: " + Deduccion + "\nSalario Neto: " + SalNeto + "\n\nPresione ENTER para finalizar...");
            Console.ReadLine(); 

        }
    }
}
