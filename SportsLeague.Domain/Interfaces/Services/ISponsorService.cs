using SportsLeague.Domain.Entities;

namespace SportsLeague.Domain.Interfaces.Services
{
    public interface ISponsorService
    {
        // CRUD básico
        Task<IEnumerable<Sponsor>> GetAllAsync();
        Task<Sponsor?> GetByIdAsync(int id);
        Task<Sponsor> CreateAsync(Sponsor sponsor);
        Task UpdateAsync(int id, Sponsor sponsor);
        Task DeleteAsync(int id);

        // Operaciones de vinculación con torneos
        Task<TournamentSponsor> LinkToTournamentAsync(int sponsorId, TournamentSponsor ts);
        Task<IEnumerable<TournamentSponsor>> GetTournamentsBySponsorAsync(int sponsorId);
        Task UnlinkFromTournamentAsync(int sponsorId, int tournamentId);
    }
}