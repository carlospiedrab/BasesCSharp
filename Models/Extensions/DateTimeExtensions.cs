using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalcularAntiguedad(this DateOnly fecha)
        {
            DateOnly hoy = DateOnly.FromDateTime(DateTime.Now);
            int antiguedad = hoy.Year - fecha.Year;
            return antiguedad;
        }
    }
}