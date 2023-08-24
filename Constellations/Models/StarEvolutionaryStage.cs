namespace Constellations.Models
{
    public class StarEvolutionaryStage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public ICollection<Star> Stars { get; set; }

    }
}
