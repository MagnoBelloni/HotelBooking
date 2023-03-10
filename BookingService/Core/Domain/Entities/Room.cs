namespace Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public bool InMaintenance { get; set; }
        public bool IsAvailable
        {
            get {
                return this.InMaintenance || this.HasGuest;
            }
        }

        public bool HasGuest { get { return true; } }
    }
}
