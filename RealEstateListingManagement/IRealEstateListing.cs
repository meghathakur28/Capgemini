using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateListingManagement
{
    public interface IRealEstateListing
    {
        int ID { get; }
        string Title { get; }
        string Description { get; }
        int Price { get; }
        string Location { get; }

    }
}
