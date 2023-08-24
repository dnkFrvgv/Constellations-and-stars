namespace Constellations.Models
{
    public class SpectralClassification
    {
        public int Id { get; set; }
        public char SpectralType { get; set; }
        public string IntrinsicColour { get; set; }
        public double SurfaceTemperatureStartKelvin { get; set; }
        public double SurfaceTemperatureEndKelvin { get; set; }
        public ICollection<Star> Stars{ get; set; }
    }
}
