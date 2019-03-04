namespace AgroClinic.Infra.CrossCutting.Shared.ExternalsViewModel.ClimaTempo
{
    public class WindDetails
    {
        public string direction { get; set; }
        public int direction_degrees { get; set; }
        public double gust_max { get; set; }
        public int velocity_max { get; set; }
    }
}
