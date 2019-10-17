using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestaurantClass
{

    private string[] staffJobs = {"FOH Manager", "BOH Manager", "FOH Host", "FOH Bartender",
        "FOH Busser", "FOH Server", "BOH Cook", "BOH Dishwasher"}; //FOH = Front of the house | BOH = Back of the house

    private int capital; //amount of money the player has


    private string[] menuList = {"Chicken Caesar Salad", "Chicken Parmesan", "Chinese Chicken Salad",
        "Deluxe Hamburger", "Filet Mignon", "Foot Long Hotdog", "Friend Chicken Tenders", "Fried Shrimp Sandwich",
        "Grilled Halibut", "Grilled Pork Chops", "Grilled Shrimp Fettucine Alfredo", "Hunter Chicken", "Lobster Ravioli",
        "Macaroni and Cheese", "Meatloaf", "NY Strip Steak", "Oven Roasted Chicken", "Pork Schnitzel",
        "Sauteed Chicken Breast", "Sauteed Duck Breast", "Spaghetti and Meatballs", "Steak Sandwich"};

    private int menuListCount;

    public RestaurantClass()
    {
        capital = 9999;
        menuListCount = menuList.Length;
    }
    
    public int getMenuListCount()
    {
        return menuListCount;
    }

    public string getMenuListItem(int index)
    {
        return menuList[index];
    }

    public void setCapital(int capital)
    {
        this.capital = capital;
    }

    public int getCapital()
    {
        return capital;
    }
}
