using AutoMapper;
using GloboTicket.TikectManagement.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.TikectManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTicket.TikectManagement.Application.Features.Events;
using GloboTicket.TikectManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TikectManagement.Application.Profiles
{
    public class MappingProfile: Profile 
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
        }
    }
}
