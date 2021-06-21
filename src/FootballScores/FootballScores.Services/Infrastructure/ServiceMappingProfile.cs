namespace FootballScores.Services.Infrastructure
{
    using Models;
    using AutoMapper;
    using OutputModels;

    public class ServiceMappingProfile : Profile
    {
        public ServiceMappingProfile()
        {
            this.CreateMap<League, LeagueOutputModel>()
                .ForMember(m => m.Fixtures, cfg => cfg.MapFrom(l => l.Fixtures))
                .ForMember(m => m.LeagueId, cfg => cfg.MapFrom(l => l.Id))
                .ForMember(m => m.LeagueName, cfg => cfg.MapFrom(l => l.Name));
        }
    }
}
