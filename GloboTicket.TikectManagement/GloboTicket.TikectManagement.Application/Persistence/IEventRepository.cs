using GloboTicket.TikectManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TikectManagement.Application.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
    }
}
