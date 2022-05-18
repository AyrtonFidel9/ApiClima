using System;
using System.Collections.Generic;

#nullable disable

namespace ApiClima.Model
{
    public partial class Clima
    {
        public int Id { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public double? ProbPrecipitaciones { get; set; }
        public double? Humedad { get; set; }
        public double? Viento { get; set; }
        public double? Temperatura { get; set; }
        public double? Sensacion { get; set; }
        public string Descripcion { get; set; }
    }
}
