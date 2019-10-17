using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Household
{
    private string household_Type; //Business, Leisure or Family
    private int adults; //1 to 2
    private int children; //1 to 3
    private int totalPeople;
    private int distance_Restaurant; //0 - 3

    private float basePercentage;



    public Household()
    {
        adults = Random.Range(1, 3);
        distance_Restaurant = Random.Range(0, 4);

        int sub = Random.Range(0, 3);

        if (sub == 1)
        {
            household_Type = "Business";
            children = 0;
        }
        else if (sub == 0)
        {
            household_Type = "Leisure";
            children = 0;
        }
        else
        {
            household_Type = "Family";
            children = Random.Range(1, 4);
        }

        totalPeople = adults + children;

        if(distance_Restaurant == 0){
            basePercentage = 0.20f;
        }
        else if(distance_Restaurant == 1 || distance_Restaurant == 2){
            basePercentage = 0.10f;
        }
        else{
            basePercentage = 0.05f;
        }
    }

    public void setHouseholdType(string household_Type)
    {
        this.household_Type = household_Type;
    }

    public string getHouseholdType()
    {
        return this.household_Type;
    }

    public void setAdults(int adults)
    {
        this.adults = adults;
    }


    public int getAdults()
    {
        return this.adults;
    }

    public void setChildren(int children)
    {
        this.children = children;
    }


    public int getChildren()
    {
        return this.children;
    }

    public void setDistance(int distance_Restaurant)
    {
        this.distance_Restaurant = distance_Restaurant;
    }

    public int getDistance()
    {
        return this.distance_Restaurant;
    }

    public int getTotalPeople(){
        return totalPeople;
    }

    public float getBasePercentage(){
        return basePercentage;
    }

    public void addBasePercentage(float addedPercent){
        basePercentage += addedPercent;
    }

    public void subtractBasePercentage(float subtractPercent){
        basePercentage -= subtractPercent;
    }

}
