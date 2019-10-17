using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultsScript : MonoBehaviour
{
    private ResultsClass results;
    private Restaurant_Script restaurant;

    public Button updateButton;

    public Text cogs;
    public Text foodCost;
    public Text drinkCost;
    public Text revenue;
    public Text foodRevenue;
    public Text drinksRevenue;
    public Text grossMargin;
    public Text profit;
    public Text totalItemSold;

    public bool active;

    
    
    // Start is called before the first frame update
    void Start()
    {
        restaurant = FindObjectOfType<Restaurant_Script>();
        results = restaurant.getResultsInfo();

        displayText();
        
        updateButton.onClick.AddListener(delegate(){
            displayText();
        });

   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void displayText(){
        Debug.Log("Display works");
        cogs.text = ((float)results.getCOGS()).ToString("F2");
        foodCost.text = ((float)results.getFoodCost()).ToString("F2");
        drinkCost.text = ((float)results.getDrinksCost()).ToString("F2");
        revenue.text = ((float)results.getRevenue()).ToString("F2");
        foodRevenue.text = ((float)results.getFoodRevenue()).ToString("F2");
        drinksRevenue.text = ((float)results.getDrinksRevenue()).ToString("F2");
        grossMargin.text = ((float)results.getGrossMargin()).ToString("F2");
        profit.text = ((float)results.getProfit()).ToString("F2");
        totalItemSold.text = ((float)results.getTotalItemsSold()).ToString("F2");
    }
}
