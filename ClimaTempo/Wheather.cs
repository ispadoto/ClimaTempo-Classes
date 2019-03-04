using System;

namespace AgroClinic.Infra.CrossCutting.Shared.ExternalsViewModel.ClimaTempo
{
    public class Wheather
    {
        public DateTime date { get; set; }
        public DateTime date_br { get; set; }
        public Humidity humidity { get; set; }
        public Rain rain { get; set; }
        public Wind wind { get; set; }
        public Uv uv { get; set; }
        public LimitsDouble thermal_sensation { get; set; }
        public TextIcon text_icon { get; set; }
        public Temperature temperature { get; set; }
    }
}
