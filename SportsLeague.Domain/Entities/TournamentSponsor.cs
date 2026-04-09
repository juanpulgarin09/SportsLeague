namespace SportsLeague.Domain.Entities
{
    public class TournamentSponsor : AuditBase
    {
        public int TournamentId { get; set; } //FK
        public int SponsorId { get; set; } //FK

        public decimal ContractAmount { get; set; } //Monto del contrato
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow; //Fecha de vinculación

        // Navigation Properties
        public Tournament Tournament { get; set; } = null!;
        public Sponsor Sponsor { get; set; } = null!;
    }
}