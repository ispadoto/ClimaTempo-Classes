using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroClinic.Infra.CrossCutting.Shared.ExternalsViewModel.ClimaTempo
{
    public class Wind
    {
        public int velocity_min { get; set; }
        public int velocity_max { get; set; }
        public int velocity_avg { get; set; }
        public double gust_max { get; set; }
        public int direction_degrees { get; set; }
        public string direction { get; set; }
        public WindDetails dawn { get; set; }
        public WindDetails morning { get; set; }
        public WindDetails afternoon { get; set; }
        public WindDetails night { get; set; }
    }
}
