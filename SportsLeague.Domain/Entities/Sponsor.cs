using SportsLeague.Domain.Enums;

namespace SportsLeague.Domain.Entities
{
    public class Sponsor : AuditBase
    {
        public string Name { get; set; } = string.Empty;
        public string ContactEmail { get; set; } = string.Empty;
        public string? Phone { get; set; }        // Nullable: es opcional
        public string? WebsiteUrl { get; set; }   // Nullable: es opcional
        public SponsorCategory Category { get; set; }

        // Navigation Property — un sponsor puede estar en muchos torneos
        public ICollection<TournamentSponsor> TournamentSponsors { get; set; }
            = new List<TournamentSponsor>();
    }
}