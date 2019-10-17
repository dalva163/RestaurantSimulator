using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Demographics_Script : MonoBehaviour
{
   public Text populationLabel;
   public Text householdLabel;
   public Text adultsLabel;
   public Text childrenLabel;
   public Text incomeLabel;

   private Demographic test;
   private Restaurant_Script restaurant;

   public int maxPopulation;
   public int minPopulation;

   

    public class Demographic
    {
        private int populationSize;
        private int totalAdults;
        private int totalChildren;
        private string income;
        private Household[] householdArray;
        private int householdAmount;

        

        public Demographic(int minPopulation,int maxPopulation)
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

            householdAmount = Random.Range(minPopulation, maxPopulation);

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

    public void restaurantDay(){
        for(int i = 0; i < test.getHouseholdAmount(); i++){
            restaurant.getInsideRestaurant(test.getHousehold(i));
        }
    }

    public void displayPopulation(Demographic test)
    {
        populationLabel.text = test.getPopulationSize().ToString();
    }

    public void displayHousehold(Demographic test)
    {
        householdLabel.text = test.getHouseholdAmount().ToString();
    }

    public void displayAdults(Demographic test)
    {
        adultsLabel.text = test.getTotalAdults().ToString();
    }

     public void displayChildren(Demographic test)
    {
        childrenLabel.text = test.getTotalChildren().ToString();
    }

     public void displayIncome(Demographic test)
    {
        incomeLabel.text = test.getIncomeType().ToString();
    }




    // Start is called before the first frame update
    void Start()
    {
        
        test = new Demographic(minPopulation,maxPopulation);
        restaurant = FindObjectOfType<Restaurant_Script>();
        displayPopulation(test);
        displayHousehold(test);
        displayAdults(test);
        displayChildren(test);
        displayIncome(test);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
