using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RealEstateListingManagement
{
    public class RealEstateApp
    {
        private List<IRealEstateListing> listings = new List<IRealEstateListing>();
        public bool AddListing(IRealEstateListing listing)
        {
            if(listing!=null)
            {
                listings.Add(listing);
                return true;
            }
            return false;
        }
        public bool RemoveListing(int listingID)
        {
            IRealEstateListing l = listings.Find(li => li.ID == listingID);
            if (l != null)
            {
                listings.Remove(l);
                return true;
            }
            return false;
        }
        public bool UpdateListing(IRealEstateListing listing)
        {
            int id = listing.ID;
            IRealEstateListing l = listings.Find(li => li.ID == id);
            if (l != null)
            {
                l = listing;
                return true;
            }
            return false;
        }

        public List<IRealEstateListing>  GetListing()
        {
            return listings;
        }
        public List<IRealEstateListing> GetListingByLocation(string location)
        {
            List<IRealEstateListing> l = listings.FindAll(li => li.Location == location);
            return l;
        }

        public List<IRealEstateListing> GetListingByPriceRange(int minPrice, int maxPrice)
        {
            List<IRealEstateListing> l = listings.FindAll(li => li.Price>=minPrice&&li.Price<=maxPrice);
            return l;
        }
    }
}
