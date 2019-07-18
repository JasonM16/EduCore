using System.Collections.Generic;

namespace Domain.CampusAggregate
{
    public class Building
    {
        
        public int BuildingId { get; set; }
        public string BuildingName { get; set; }
        public string Abbreviation { get; set; }

        public ICollection<ClassRoom> ClassRooms { get; set; } = new HashSet<ClassRoom>();
    }
}
