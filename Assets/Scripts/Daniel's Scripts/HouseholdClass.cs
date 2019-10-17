using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Household
{
    private string household_Type; //Business or Leisure
    private int adults; //1 to 2
    private int children; //0 to 3
    private int distance_Restaurant; //0 - 3

    public Household()
    {
        adults = Random.Range(1, 3);
        children = Random.Range(0, 4);
        distance_Restaurant = Random.Range(0, 4);

        if (Random.Range(0, 2) == 1)
        {
            household_Type = "Business";
        }
        else
        {
            household_Type = "Leisure";
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

}
