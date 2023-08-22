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
        public EvolutionaryStage EvolutionaryStage { get; set; }
        public float TemperatureKelvin { get; set; }
        public float AbsoluteMagnitude { get; set; }
        public float ApparentMagnitude { get; set; }
        public float SolarMass { get; set; }
        public float AgeMillionYrs { get; set; }
        public float Luminosity { get; set; }
    }
}
