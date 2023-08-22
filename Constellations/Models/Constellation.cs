namespace Constellations.Models
{
    public class Constellation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Hemisphere { get; set; }
        public string Quadrant { get; set; }
        public Star BrightestStar { get; set; }
        public int NumberOfStars { get; set; }
        IEnumerable<Star> Stars { get; set; }
    }
}
