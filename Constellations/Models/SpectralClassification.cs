namespace Constellations.Models
{
    public class SpectralClassification
    {
        public int Id { get; set; }
        public char SpectralType { get; set; }
        public string IntrinsicColour { get; set; }
        public float SurfaceTemperatureStartKelvin { get; set; }
        public float SurfaceTemperatureEndKelvin { get; set; }
    }
}
