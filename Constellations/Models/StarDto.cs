using System.ComponentModel.DataAnnotations;

namespace Constellations.Models
{
    public class StarDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public int ConstallationId { get; set; }
        [Required]
        public int SpectralClassificationId { get; set; }
        [Required]
        public int EvolutionaryStageId { get; set; }
        [Required]
        public double SurfaceTemperatureKelvin { get; set; }
        [Required]
        public double AbsoluteMagnitude { get; set; }
        [Required]
        public double ApparentMagnitude { get; set; }
        [Required]
        public double SolarMass { get; set; }
        [Required]
        public double AgeMillionYrs { get; set; }
        [Required]
        public double Luminosity { get; set; }
        [Required]
        public double ApproximateDistanceFromEarthLightYrs { get; set; }
    }
}
