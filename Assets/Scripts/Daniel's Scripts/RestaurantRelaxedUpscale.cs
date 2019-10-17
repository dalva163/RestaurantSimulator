using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestaurantRelaxedUpscale : RestaurantClass
{
    private string restaurantTargetDemographic; //business, leisure and leisure with kids(Family)
    private string restaurantType = "Relaxed Upscale";

    private int maxMenuLayoutEntrees = 10;
    private int maxMenuLayoutDrinks = 5;

    private string[] menuLayoutEntrees; //max 10 menu items for entrees
    private string[] menuLayoutDrinks; //max 5 menu items for drinks


    private int openDuring = 2; //can be lunch(1), dinner(2) or both(3) but we are only doing with dinner for now
    private int[] peakDaysBusiness = {1, 2, 3, 4}; //0 = Sunday | 1 = Monday | 2 = Tuesday | 3 = Wednesday | 4 = Thursday | 5 = Friday | 6 is Saturday
    private int[] offPeakDaysBusiness = {5, 6, 0};
    private int[] peakDaysLeisure = {4, 5, 6};
    private int[] offPeakDaysLeisure = {0, 1, 2, 3};
    private int[] peakDaysFamily = {5, 6};
    private int[] offPeakDaysFamily = {0, 1, 2, 3, 4};

    private string[] correctMenuLayoutEntreesBusiness = { "NY Strip Steak", "Grilled Pork Chops",
        "Sauteed Chicken Breast", "Pork Schnitzel", "Oven Roasted Half Chicken",
        "Grilled Halibut", "Lobster Ravioli", "Grilled Shrimp Fettucine Alfredo",
        "Chicken Caesar Salad", "Fried Shrimp Sandwich"};

    private string[] correctMenuLayoutEntreesLeisure = {"Oven Roasted Half Chicken", "NY Strip Steak", "Chicken Caesar Salad",
        "Grilled Pork Chops", "Sauteed Chicken Breast", "Fried Shrimp Sandwich", "Pork Schintzel",
        "Grilled Halibut", "Lobster Ravioli", "Grilled Shrimp Fettucine Alfredo"};

    private string[] correctMenuLayoutEntreesFamily = {"Oven Roasted Half Chicken", "Chicken Caesar Salad",
        "Grilled Pork Chops", "Sauteed CHicken Breast", "Fried Shrimp Sandwich", "Pork Schnitzel",
        "Grilled Shrimp Fettucine Alfredo", "Fried Chicken Tenders", "Foot Long Hotdog", "Macaroni and Cheese"};

    private string[] correctMenuLayoutDrinksBusiness = { "Liquor", "Beer/Wine", "Coffee", "Ice Tea", "Soda" };

    private string[] correctMenuLayoutDrinksLeisure = { "Beer/Wine", "Liquor", "Soda", "Coffee", "Iced Tea" };

    private string[] correctMenuLayoutDrinksFamily = { "Beer/Wine", "Soda", "Chocolate Milk", "Iced Tea", "Coffee" };


    //contructor for when creating a relaxed upscale restaurant
    public RestaurantRelaxedUpscale()
    {
        menuLayoutEntrees = new string[maxMenuLayoutEntrees];
        menuLayoutDrinks = new string[maxMenuLayoutDrinks];
    }


    public string getRestaurantType()
    {
        return restaurantType;
    }


    public void setOpenDuring(int openDuring)
    {
        this.openDuring = openDuring;
    }


    public int getOpenDuring()
    {
        return this.openDuring;
    }


    public void setRestaurantTargetDemographic(string restaurantTargetDemographic)
    {
        this.restaurantTargetDemographic = restaurantTargetDemographic;
    }


    public string getRestaurantTargetDemographic()
    {
        return restaurantTargetDemographic;
    }

    //this function checks what day the system time is on and if that day is a peak day for the restaurant type and returns true if it is a peak day
    public bool checkIfPeakDay(int currentDay)
    {
        if (restaurantTargetDemographic.Equals("Business"))
        {
            for (int i = 0; i < peakDaysBusiness.Length; i++)
            {
                if (peakDaysBusiness[i] == currentDay)
                {
                    return true;
                }
            }

        }
        else if (restaurantTargetDemographic.Equals("Leisure"))
        {
            for (int i = 0; i < peakDaysLeisure.Length; i++)
            {
                if (peakDaysLeisure[i] == currentDay)
                {
                    return true;
                }
            }

        }
        else
        {
            for (int i = 0; i < peakDaysFamily.Length; i++)
            {
                if (peakDaysFamily[i] == currentDay)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public int getMaxMenuLayoutEntrees()
    {
        return maxMenuLayoutEntrees;
    }

    public int getMaxMenuLayoutDrinks()
    {
        return maxMenuLayoutDrinks;
    }

    public void setMenuLayoutEntrees(string[] menuLayoutEntrees)
    {
        for (int i = 0; i < menuLayoutEntrees.Length; i++)
        {
            this.menuLayoutEntrees[i] = menuLayoutEntrees[i];
        }
    }


    public string getMenuLayoutEntrees(int index)
    {
        return menuLayoutEntrees[index];
    }

    public void setMenuLayoutDrinks(string[] menuLayoutDrinks)
    {
        for (int i = 0; i < menuLayoutDrinks.Length; i++)
        {
            this.menuLayoutDrinks[i] = menuLayoutDrinks[i];
        }
    }


    public string getMenuLayoutDrinks(int index)
    {
        return menuLayoutDrinks[index];
    }
}
