using System;
using RealEstateListingManagement;
public class Program
{
    public static void Menu()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Welcome to the Real Estate Listing Management System ");
        Console.WriteLine("1. Add Listing");
        Console.WriteLine("2. Remove Listing");
        Console.WriteLine("3. UpdateListing");
        Console.WriteLine("4. GetListing");
        Console.WriteLine("5. GetListingByLocation");
        Console.WriteLine("6. GetListingByPriceRange");
        Console.WriteLine("7. Exit");
        Console.ResetColor();
    }
    public static void Main(string[] args)
    {
        RealEstateApp app = new RealEstateApp();
        int choice = 0;
        while(choice !=7)
        {
            Menu();
            Console.Write("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());   
            switch(choice)
            {
                case 1:
                    {
                        RealEstateListing realObj = new RealEstateListing(); 
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Add The details");
                        Console.Write("Enter the ID: ");
                        realObj.ID = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter the Title: ");
                        realObj.Title = Console.ReadLine();
                        Console.Write("Enter the Discription: ");
                        realObj.Description = Console.ReadLine();
                        Console.Write("Enter the Price: ");
                        realObj.Price = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter the Location: ");
                        realObj.Location = Console.ReadLine();
                        Console.ResetColor();
                        try
                        {
                            bool ans = app.AddListing(realObj);
                            if (ans)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Listing Added Successfully");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Not Added");
                                Console.ResetColor();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter the id which u wantt to remove: ");
                        int id = Int32.Parse(Console.ReadLine());
                        try
                        {
                            bool ans = app.RemoveListing(id);
                            if (ans)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Listing removed Successfully");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Not removed");
                                Console.ResetColor();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        break;
                    }
                case 3:
                    {
                        RealEstateListing realObj = new RealEstateListing();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Enter The details");
                        Console.Write("Enter the ID: ");
                        realObj.ID = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter the Title: ");
                        realObj.Title = Console.ReadLine();
                        Console.Write("Enter the Discription: ");
                        realObj.Description = Console.ReadLine();
                        Console.Write("Enter the Price: ");
                        realObj.Price = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter the Location: ");
                        realObj.Location = Console.ReadLine();
                        Console.ResetColor();
                        try
                        {
                            bool ans = app.UpdateListing(realObj);
                            if (ans)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Listing updated Successfully");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Not Updated");
                                Console.ResetColor();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        break;
                    }
                case 4:
                    {
                        List<IRealEstateListing> l = app.GetListing();
                        if(l.Count>0)
                        {
                            foreach(var i in l)
                            {
                                Console.WriteLine("ID: " + i.ID + " \tTitle: " + i.Title + "\tDescription: " + i.Description + "\tPrice: " + i.Price + "\tLocation: " + i.Location);
                            }
                        }
                        break;
                    }
                case 5:
                    {
                        Console.Write("Enter the Location: ");
                        string location = Console.ReadLine();
                        List<IRealEstateListing> l = app.GetListingByLocation(location);
                        if (l.Count > 0)
                        {
                            foreach (var i in l)
                            {
                                Console.WriteLine("ID: " + i.ID + " \tTitle: " + i.Title + "\tDescription: " + i.Description + "\tPrice: " + i.Price + "\tLocation: " + i.Location);
                            }
                        }
                        break;
                    }
                case 6:
                    {
                        Console.Write("Enter the price range");
                        Console.Write("Enter the Min Price: ");
                        int min = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter the Max Price: ");
                        int max = Int32.Parse(Console.ReadLine());
                        List<IRealEstateListing> l = app.GetListingByPriceRange(min,max);
                        if (l.Count > 0)
                        {
                            foreach (var i in l)
                            {
                                Console.WriteLine("ID: " + i.ID + " \tTitle: " + i.Title + "\tDescription: " + i.Description + "\tPrice: " + i.Price + "\tLocation: " + i.Location);
                            }
                        }
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Exiting......");
                        Console.WriteLine("Thanlyou for using the Real Estate Listing Management System");
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Invalid choice. Please make a valid choice");
                        break;
                    }

            }
        }

    }
}