namespace AgroClinic.Infra.CrossCutting.Shared.ExternalsViewModel.ClimaTempo
{
    public class Temperature
    {
        public int min { get; set; }
        public int max { get; set; }
        public Limits dawn { get; set; }
        public Limits morning { get; set; }
        public Limits afternoon { get; set; }
        public Limits night { get; set; }
    }
}
