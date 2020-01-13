using ExcelNugget02;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaExcelFormat
{
    public class Prueba
    {
        [DescripcionExcel(Name = "NOMBRE", Ignore = false)]
        public string Name { get; set; }
        [DescripcionExcel(Name = "EDAD", Ignore = false)]
        public int edad { get; set; }
        [DescripcionExcel(Name = "AÑO", Ignore = false)]
        public int anio { get; set; }
        [DescripcionExcel(Name = "FECHA", Ignore = false)]
        public int fecha { get; set; }
        [DescripcionExcel(Name = "HORA", Ignore = false)]
        public int hora { get; set; }
        [DescripcionExcel(Name = "DESCRIPCION", Ignore = false)]
        public string descripcion { get; set; }
    }
}
