using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItemClass
{
    private string itemName;
    private double itemPrice; //selling price of the item
    private double popularityIndex;
    private double basePopularity;
    private double totalPopularity;
    private double sweetSpot;
    private double itemIngredientsCost; //the amount needed to buy the item to sell to customers
    private int dailyQtySold;
    private int QtySold;

    private double margin; //price - cost on all items in the restaurant
    private double grossSales; //price * quantity sold
    private double grossProfit; //margin * quantity sold on all items
    private double foodCostPercent; // cost/price
    private double percentUnitSales; //quantity sold/total tiems sold

    public MenuItemClass(string itemName)
    {
        this.itemName = itemName;
        itemPrice = 0;
        popularityIndex = 0;
        basePopularity = 0;
        totalPopularity = 0;
        sweetSpot = 0;
        itemIngredientsCost = 0;
        dailyQtySold = 0;
        QtySold = 0;
        margin = 0;
        grossSales = 0;
        grossProfit = 0;
        foodCostPercent = 0;
        percentUnitSales = 0;
    }


    public void generateReport()
    {
        margin = itemPrice - itemIngredientsCost;

        grossSales = itemPrice * QtySold;

        grossProfit = margin * QtySold;

        foodCostPercent = itemIngredientsCost / itemPrice;
    }

    public void addPercentages(){
        totalPopularity = basePopularity + popularityIndex + sweetSpot;
    }

    public double getTotalPercentage(){
        return totalPopularity;
    }

    public void itemBuy(){
        dailyQtySold++;
        QtySold++;
    }


    public void resetDailyQtySold()
    {
        dailyQtySold = 0;
    }

    public void setPercentUnitSales(double totalItemsSold)
    {
        percentUnitSales = QtySold / totalItemsSold;
    }


    public double getPercentUnitSales()
    {
        return percentUnitSales;
    }


    public double getMargin()
    {
        return margin;
    }


    public double getGrossSales()
    {
        return grossSales;
    }


    public double getGrossProfit()
    {
        return grossProfit;
    }


    public double getFoddCostPercent()
    {
        return foodCostPercent;
    }


    public void setItemIngredientsCost(double itemIngredientsCost)
    {
        this.itemIngredientsCost = itemIngredientsCost;
    }


    public double getItemIngredientsCost()
    {
        return itemIngredientsCost;
    }


    public int getDailyQtySold()
    {
        return dailyQtySold;
    }


    public int getQtySold()
    {
        return QtySold;
    }


    public double getBasePopularity()
    {
        return basePopularity;
    }


    public void setBasePopularity(double basePopularity)
    {
        this.basePopularity = basePopularity;
    }


    public string getItemName()
    {
        return itemName;
    }


    public void setItemName(string itemName)
    {
        this.itemName = itemName;
    }


    public double getItemPrice()
    {
        return itemPrice;
    }


    public void setItemPrice(double itemPrice)
    {
        this.itemPrice = itemPrice;
    }


    public double getPopularityIndex()
    {
        return popularityIndex;
    }


    public void setPopularityIndex(double popularityIndex)
    {
        this.popularityIndex = popularityIndex;
    }


    public void setSweetSpot(double sweetSpot)
    {
        this.sweetSpot = sweetSpot;
    }


    public double getSweetSpot()
    {
        return sweetSpot;
    }
}
