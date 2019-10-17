using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Demographics_Script : MonoBehaviour
{
   

    public class Demographic
    {
        private int populationSize;
        private int totalAdults;
        private int totalChildren;
        private string income;
        private Household[] householdArray;
        private int householdAmount;

        public Demographic()
        {
            int temp = Random.Range(1, 4);

            totalAdults = 0;
            totalChildren = 0;

            if (temp == 1)
            {
                income = "Low";
            }else if(temp == 2)
            {
                income = "Middle";
            }
            else
            {
                income = "High";
            }

            householdAmount = Random.Range(1, 11);

            generateHouseholds();

            countPopulationSize();

        }

        public void generateHouseholds()
        {

            householdArray = new Household[householdAmount];

            for(int i = 0; i < householdAmount; i++)
            {
                householdArray[i] = new Household();
            }
        }

        public void countPopulationSize()
        {
            for(int i = 0; i < householdAmount; i++)
            {
                totalAdults = totalAdults + householdArray[i].getAdults();
                totalChildren = totalChildren + householdArray[i].getChildren();
            }

            populationSize = totalAdults + totalChildren;
        }

        public int getPopulationSize()
        {
            return this.populationSize;
        }

        public void setIncomeType(string income)
        {
            this.income = income;
        }

        public string getIncomeType()
        {
            return this.income;
        }

        public string getIncomeText()
        {
            if(income.Equals("Low"))
            {
                return income + "Income Level - $12 and below a 70% chance to buy the item. Above $12 a 30% chance to buy the item";
            }
            else if(income.Equals("High"))
            {
                return income + "Income Level - Under %12 a 20% chance to buy the item. Between $12 - $20 a 70% chance to buy the item. Above $20 a 10% chance to buy the item";
            }
            else
            {
                return income + "Income Level - $20 and above a 70% chance to buy the item. Under $20 a 30% chance to buy the item";
            }
        }

        public void setTotalAdults(int totalAdults)
        {
            this.totalAdults = totalAdults;
        }

        public int getTotalAdults()
        {
            return this.totalAdults;
        }

        public void setTotalChildren(int totalChildren)
        {
            this.totalChildren = totalChildren;
        }

        public int getTotalChildren()
        {
            return this.totalChildren;
        }

        public Household getHousehold(int index)
        {
            return this.householdArray[index];
        }

        public void setHouseholdAmount(int householdAmount)
        {
            this.householdAmount = householdAmount;
        }

        public int getHouseholdAmount()
        {
            return this.householdAmount;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        //Demographic test = new Demographic();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
