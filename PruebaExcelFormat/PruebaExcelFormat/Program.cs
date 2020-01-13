using ExcelNugget02;
using ExcelNugget02.Interfaces;
using System;
using System.Collections.Generic;

namespace PruebaExcelFormat
{
    class Program
    {
        /*utiliza epplus.core para usar el nugget*/
        static void Main(string[] args)
        {
            List<Prueba> lista = new List<Prueba>() {
               new Prueba(){
                   Name="edwin alexander nolasco1",
                    edad=25,
                   anio=2019,
                   fecha=20191223,
                   hora=1451

               },
                  new Prueba(){
                   Name="edwin2",
                   edad=25,
                   anio=2019,
                   fecha=20191223,
                   hora=1451,
                   descripcion="asasasa1s..............................."
               },
                      new Prueba(){
                   Name="edwin3",
                   edad=25,
                   anio=2019,
                   fecha=20191223,
                   hora=1451,
                   descripcion="a"
               },
           };

            /*especificar donde se gurdar el documento*/
            IExcel excel = new Excel();
            var nombreArchivo = "Prueba";
            /*especificar donde se gurdar el documento segun lo necesita ejemplo c:\*/
            excel.GuardarArchivo(@"C:\excel\", nombreArchivo);
            /*mandamos la lista de datos que queremos agregar al excel*/
            var resp =  excel.NewContent(lista);
            /*si la respuesta el tru el excel fue generado con exito */
            Console.WriteLine(resp.Result);       
        }
    }
}
