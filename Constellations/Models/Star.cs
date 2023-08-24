using Microsoft.AspNetCore.Mvc;

namespace Constellations.Models
{
    public class Star
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public int ConstallationId { get; set; }
        public Constellation Constellation { get; set; }
        public int SpectralClassificationId { get; set; }
        public SpectralClassification SpectralClassification { get; set; }
        public int EvolutionaryStageId { get; set; }
        public StarEvolutionaryStage EvolutionaryStage { get; set; }
        public double SurfaceTemperatureKelvin { get; set; }
        public double AbsoluteMagnitude { get; set; }
        public double ApparentMagnitude { get; set; }
        public double SolarMass { get; set; }
        public double AgeMillionYrs { get; set; }
        public double Luminosity { get; set; }
        public double ApproximateDistanceFromEarthLightYrs { get; set; }    
    }
}
