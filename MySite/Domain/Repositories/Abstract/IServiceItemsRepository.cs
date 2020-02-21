using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySite.Domain.Entities;

namespace MySite.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<SeviceItem> GetServiceItems();
        SeviceItem GetServiceItemById(Guid id);
        void SaveServiceItem(SeviceItem entityy);
        void DeleteServiceItem(Guid id);

    }
}
