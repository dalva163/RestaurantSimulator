using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultsClass
{
    private double cogs; //Cost of Goods Sold
    private double foodCost;
    private double drinksCost;

    private double revenue;
    private double foodRevenue;
    private double drinksRevenue;
    private double grossMargin; //sum of food and drinks revenue - cogs

    private double buildingLease;
    private double profit; //groos margin - sum of all expenses

    private double totalItemsSold;


    public ResultsClass(string type)
    {

        if(type.Equals("Fine Dining"))
        {
            buildingLease = 6000;
        }else if(type.Equals("Relaxed Upscaled"))
        {
            buildingLease = 4000;
        }else
        {
            buildingLease = 2000;
        }

        cogs = 0;
        foodCost = 0;
        drinksCost = 0;
        revenue = 0;
        foodRevenue = 0;
        drinksRevenue = 0;
        grossMargin = 0;
        profit = 0;
        totalItemsSold = 0;
    }

    //will calculate the food and drinks cost and then call the function to calculate the COGS
    public void generateFoodAndDrinksCost(MenuItemClass[] entreesMenuLayout, MenuItemClass[] drinksMenuLayout, int entreeCount, int drinkCount)
    {
        for(int i = 0; i < entreeCount; i++)
        {
            foodCost = foodCost + (entreesMenuLayout[i].getItemIngredientsCost() * entreesMenuLayout[i].getDailyQtySold());
            Debug.Log("Food Cost: "+ foodCost);
        }

        for(int i = 0; i < drinkCount; i++)
        {
            drinksCost = drinksCost + (drinksMenuLayout[i].getItemIngredientsCost() * drinksMenuLayout[i].getDailyQtySold());
            Debug.Log("Drink Cost: "+ drinksCost);
        }

        calculateCOGS();
    }

    //helper function that calculates the COGS
    public void calculateCOGS()
    {
        cogs = foodCost + drinksCost;
    }

    //will calculate each food and drinks revenue and the call the function to calculate the revenue
    public void generateFoodAndDrinksRevenue(MenuItemClass[] entreesMenuLayout, MenuItemClass[] drinksMenuLayout, int entreeCount, int drinkCount)
    {
        for (int i = 0; i < entreeCount; i++)
        {
            foodRevenue = foodRevenue + (entreesMenuLayout[i].getItemPrice() * entreesMenuLayout[i].getDailyQtySold());
        }

        for (int i = 0; i < drinkCount; i++)
        {
            drinksRevenue = drinksRevenue + (drinksMenuLayout[i].getItemPrice() * drinksMenuLayout[i].getDailyQtySold());
        }

        calculateRevenue();
    }

    //helper function that calculates the revenue
    public void calculateRevenue()
    {
        revenue = foodRevenue + drinksRevenue;
    }

    //generates the gross margin
    public void generateGrossMargin()
    {
        grossMargin = (foodRevenue + drinksRevenue) - cogs;
    }

    //generates the profit
    public void generateProfit()
    {
        profit = grossMargin;
    }


    public void deductBuildingLease()
    {
        profit = profit - buildingLease;
    }

    // will total all items sold and then calculate each iems percent unit sales
    public void generateTotalItemsSold(MenuItemClass[] entreesMenuLayout, MenuItemClass[] drinksMenuLayout, int entreeCount, int drinkCount)
    {
        for (int i = 0; i < entreeCount; i++)
        {
            totalItemsSold = totalItemsSold + entreesMenuLayout[i].getDailyQtySold();
        }

        for (int i = 0; i < drinkCount; i++)
        {
            totalItemsSold = totalItemsSold + drinksMenuLayout[i].getDailyQtySold();
        }

        //after summing the total items sold it now calculates the percent unit sales per item
        for (int i = 0; i < entreeCount; i++)
        {
            entreesMenuLayout[i].setPercentUnitSales(totalItemsSold);
            entreesMenuLayout[i].resetDailyQtySold();
        }

        for (int i = 0; i < drinkCount; i++)
        {
            drinksMenuLayout[i].setPercentUnitSales(totalItemsSold);
            drinksMenuLayout[i].resetDailyQtySold();
        }
    }


    //all getter functions for the variables
    public double getCOGS()
    {
        return cogs;
    }


    public double getFoodCost()
    {
        return foodCost;
    }


    public double getDrinksCost()
    {
        return drinksCost;
    }


    public double getRevenue()
    {
        return revenue;
    }


    public double getFoodRevenue()
    {
        return foodRevenue;
    }


    public double getDrinksRevenue()
    {
        return drinksRevenue;
    }


    public double getGrossMargin()
    {
        return grossMargin;
    }


    public double getProfit()
    {
        return profit;
    }

    public double getTotalItemsSold(){
        return totalItemsSold;
    }
}
