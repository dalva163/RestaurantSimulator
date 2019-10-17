using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsClass : MonoBehaviour
{
    private Dictionary<string, List<string>> recipeListItems = new Dictionary<string, List<string>>();
    private Dictionary<string, List<int>> recipeListItemsAmount = new Dictionary<string, List<int>>();



    // Start is called before the first frame update
    void Start()
    {
        recipeListItems.Add("Chicken Caesar Salad", new List<string> {"Chicken Breast", "Romaine Lettuce",
            "Caesar Dressing", "Parmesan Cheese", "Croutons"});

        recipeListItems.Add("Chicken Parmesan", new List<string> {"Chicken Breast", "Breadcrumbs",
            "Oil/Butter", "Tomato Sauce", "Mozzarella Cheese", "Parmesan Cheese", "Fresh Herbs", "Dry Spices", "Pasta"});

        recipeListItems.Add("Chinese Chicken Salad", new List<string> {"Chicken Breast", "Romaine Lettuce",
            "Spicy Peanut Salad Dressing", "Fresh Vegetables", "Nuts", "Fresh Herbs", "Dry Spices"});

        recipeListItems.Add("Deluxe Hamburger", new List<string> {"Ground Beef", "Dry Spices", "Hamburger Bun",
            "Romaine Lettuce", "Fresh Vegetables", "Pickle", "French Fries", "Ketchup"});


        Debug.Log(recipeListItems["Chicken Caesar Salad"][0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
