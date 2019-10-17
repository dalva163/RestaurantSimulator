using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RestaurantCasualDining test1 = new RestaurantCasualDining();
        RestaurantRelaxedUpscale test2 = new RestaurantRelaxedUpscale();
        RestaurantFineDining test3 = new RestaurantFineDining();

        test1.setRestaurantTargetDemographic("Family");
        test2.setRestaurantTargetDemographic("Leisure");
        test3.setRestaurantTargetDemographic("Business");

        string[] testStringEntrees = {"Fried Chicken Tenders", "Chicken Caesar Salad",
        "Spaghetti and Meatballs", "Chicken Parmesan", "Foot Long Hotdog", "Meatloaf", "Macaroni and Cheese",
        "Grilled Shrimp Fettucine Alfredo", "Deluxe Hamburger", "Grilled Pork Chops"};
        string[] testStringDrinks = { "Beer/Wine", "Liquor", "Iced Tea", "Soda", "Coffee" };

        test1.setMenuLayoutEntrees(testStringEntrees);
        test1.setMenuLayoutDrinks(testStringDrinks);
        test2.setMenuLayoutEntrees(testStringEntrees);
        test2.setMenuLayoutDrinks(testStringDrinks);
        test3.setMenuLayoutEntrees(testStringEntrees);
        test3.setMenuLayoutDrinks(testStringDrinks);

        Debug.Log(test1.getRestaurantType() + "************************");
        Debug.Log("open during: " + test1.getOpenDuring());
        Debug.Log("target demographic: " + test1.getRestaurantTargetDemographic());
        Debug.Log("peak day: " + test1.checkIfPeakDay(2));
        Debug.Log("max menu entrees count: " + test1.getMaxMenuLayoutEntrees());
        Debug.Log("max menu drinks count: " + test1.getMaxMenuLayoutDrinks());
        
        for(int i = 0; i < 10; i++)
        {
            Debug.Log("menu entrees item " + (i + 1) + ": " + test1.getMenuLayoutEntrees(i));
        }

        for(int i = 0; i < 5; i++)
        {
            Debug.Log("menu drinks item " + (i + 1) + ": " + test1.getMenuLayoutDrinks(i));
        }

        Debug.Log("capital: " + test1.getCapital());

        Debug.Log(test2.getRestaurantType() + "************************");
        Debug.Log("open during: " + test2.getOpenDuring());
        Debug.Log("target demographic: " + test2.getRestaurantTargetDemographic());
        Debug.Log("peak day: " + test2.checkIfPeakDay(0));
        Debug.Log("max menu entrees count: " + test2.getMaxMenuLayoutEntrees());
        Debug.Log("max menu drinks count: " + test2.getMaxMenuLayoutDrinks());

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("menu entrees item " + (i + 1) + ": " + test2.getMenuLayoutEntrees(i));
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log("menu drinks item " + (i + 1) + ": " + test2.getMenuLayoutDrinks(i));
        }

        Debug.Log("capital: " + test2.getCapital());

        Debug.Log(test3.getRestaurantType() + "************************");
        Debug.Log("open during: " + test3.getOpenDuring());
        Debug.Log("target demographic: " + test3.getRestaurantTargetDemographic());
        Debug.Log("peak day: " + test3.checkIfPeakDay(5));
        Debug.Log("max menu entrees count: " + test3.getMaxMenuLayoutEntrees());
        Debug.Log("max menu drinks count: " + test3.getMaxMenuLayoutDrinks());

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("menu entrees item " + (i + 1) + ": " + test3.getMenuLayoutEntrees(i));
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log("menu drinks item " + (i + 1) + ": " + test3.getMenuLayoutDrinks(i));
        }

        Debug.Log("capital: " + test3.getCapital());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
