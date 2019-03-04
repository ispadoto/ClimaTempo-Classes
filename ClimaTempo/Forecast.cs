using System.Collections.Generic;

namespace AgroClinic.Infra.CrossCutting.Shared.ExternalsViewModel.ClimaTempo
{
    public class Forecast
    {
        public int id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public List<Wheather> data { get; set; }
        public Forecast()
        {
            data = new List<Wheather>();
        }
    }
}
