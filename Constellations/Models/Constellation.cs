namespace Constellations.Models
{
    public class Constellation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Hemisphere { get; set; }
        public string Quadrant { get; set; }
        public int NumberOfStars { get; set; }
        public ICollection<Star> Stars { get; set; }

        public void AddRangeStars(IEnumerable<Star> stars) 
        { 
            foreach(var star in stars)
            {
                Stars.Add(star);
            }
        }
        public void RemoveRangeStars(IEnumerable<Star> stars)
        { 
            foreach(var star in stars)
            {
                Stars.Remove(star);
            }
        }
    }
}
