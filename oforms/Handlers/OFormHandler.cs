using System.Linq;
using Orchard.ContentManagement.Handlers;
using oforms.Models;
using Orchard.Data;
using oforms.Services;
using Orchard.Localization.Services;

namespace oforms.Handlers
{
    public class OFormHandler : ContentHandler
    {
        public OFormHandler(IRepository<OFormPartRecord> repo)
        {
            Filters.Add(StorageFilter.For(repo));
        }
    }
}