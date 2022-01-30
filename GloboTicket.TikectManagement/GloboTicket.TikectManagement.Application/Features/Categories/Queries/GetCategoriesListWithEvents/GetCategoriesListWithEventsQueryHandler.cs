using AutoMapper;
using GloboTicket.TikectManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTicket.TikectManagement.Application.Contracts.Persistence;
using GloboTicket.TikectManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TikectManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQueryHandler : IRequestHandler<GetCategoriesListWithEventsQuery, List<CategoryEventListVm>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesListWithEventsQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        public async Task<List<CategoryEventListVm>> Handle(GetCategoriesListWithEventsQuery request, CancellationToken cancellationToken)
        {
            var allCategories = (await _categoryRepository.GetCategoriesWithEvents(request.IncludeHistory));
            return _mapper.Map<List<CategoryEventListVm>>(allCategories);

        }
    }
}
