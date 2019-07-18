namespace Domain.CampusAggregate
{
    public class ClassRoom
    {
        public int ClassRoomId { get; set; }
        public string Room { get; set; }
        public int SeatingCapacity { get; set; }
        public int BuildingId { get; set; }
    }
}
