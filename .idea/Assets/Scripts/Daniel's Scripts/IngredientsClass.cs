using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsClass
{
    private Dictionary<string, List<string>> recipeListItems = new Dictionary<string, List<string>>();//recipes and ingredients
    private Dictionary<string, List<double>> recipeListItemsAmount = new Dictionary<string, List<double>>();//recipes ingredients amount

    private Dictionary<string, double> ingredientsCost = new Dictionary<string, double>(); //list of ingredients and cost

    private Dictionary<string, double> drinksCost = new Dictionary<string, double>();

    private Dictionary<string, double> entreesLowSweetSpot = new Dictionary<string, double>();

    private Dictionary<string, double> entreesHighSweetSpot = new Dictionary<string, double>();

    private string[] ingredientsList = {"Beef Filet", "Bread Crumbs", "Caesar Dressing", "Cheddar Cheese", "Chicken Breast",
        "Chicken Tenders", "Cooking Wine", "Cream", "Croutons", "Dry Spices", "Duck Breast", "French Fries",
        "Fresh Herbs", "Fresh Vegetables", "Ground Beef", "Half Chicken", "Halibut Filet", "Hamburger Bun", "Hoagie Roll",
        "Hot Dog", "Ketchup", "Lobster Ravioli", "Mozzarella Cheese", "Nuts", "NY Strip Steak", "Oil/Butter",
        "Parmesan Cheese", "Pasta", "Pickle", "Pork Chops", "Potatoes", "Rice", "Romaine Lettuce", "Shrimp",
        "Spicy Peanut Salad Dressing", "Tomato Sauce"};

    private int ingredientsListSize;

    // Start is called before the first frame update
    public IngredientsClass()
    {

        //***************************************************************************************************
        //Chicken Caesar Salad Recipe
        recipeListItems.Add("Chicken Caesar Salad", new List<string> {"Chicken Breast", "Romaine Lettuce",
            "Caesar Dressing", "Parmesan Cheese", "Croutons"});

        recipeListItemsAmount.Add("Chicken Caesar Salad", new List<double> { 2, 4, 2, 2, 1 });

        //*****************************************************************************************************
        //Chicken Parmesan Recipe
        recipeListItems.Add("Chicken Parmesan", new List<string> {"Chicken Breast", "Bread Crumbs",
            "Oil/Butter", "Tomato Sauce", "Mozzarella Cheese", "Parmesan Cheese", "Fresh Herbs", "Dry Spices", "Pasta"});

        recipeListItemsAmount.Add("Chicken Parmesan", new List<double> { 2, 1, 1, 2, 2, 2, 1, 1, 2 });

        //******************************************************************************************************
        //Chinese Chicken Salad Recipe
        recipeListItems.Add("Chinese Chicken Salad", new List<string> {"Chicken Breast", "Romaine Lettuce",
            "Spicy Peanut Salad Dressing", "Fresh Vegetables", "Nuts", "Fresh Herbs", "Dry Spices"});

        recipeListItemsAmount.Add("Chinese Chicken Salad", new List<double> { 2, 3, 2, 1, 1, 1, 1 });

        //*******************************************************************************************************
        //Deluxe Hamburger Recipe
        recipeListItems.Add("Deluxe Hamburger", new List<string> {"Ground Beef", "Dry Spices", "Hamburger Bun",
            "Romaine Lettuce", "Fresh Vegetables", "Pickle", "French Fries", "Ketchup"});

        recipeListItemsAmount.Add("Deluxe Hamburger", new List<double> { 2, 1, 1, 0.5, 0.5, 1, 1, 1 });

        //********************************************************************************************************
        //Filet Mignon Recipe
        recipeListItems.Add("Filet Mignon", new List<string> {"Beef Filet", "Dry Spices", "Fresh Herbs",
            "Oil/Butter", "Potatoes", "Fresh Vegetables", "Cooking Wine"});

        recipeListItemsAmount.Add("Filet Mignon", new List<double> { 2, 1, 1, 2, 1, 2, 1 });

        //*********************************************************************************************************
        //Foot Long Hotdog Recipe
        recipeListItems.Add("Foot Long Hotdog", new List<string> {"Hot Dog", "Hoagie Roll", "French Fries",
            "Ketchup"});

        recipeListItemsAmount.Add("Foot Long Hotdog", new List<double> { 1, 1, 1, 1 });

        //***********************************************************************************************************
        //Fried Chicken Tenders Recipe
        recipeListItems.Add("Fried Chicken Tenders", new List<string> { "Chicken Tenders", "French Fries", "Ketchup" });

        recipeListItemsAmount.Add("Fried Chicken Tenders", new List<double> { 4, 1, 1 });

        //***********************************************************************************************************
        //Fried Shrimp Sandwich Recipe
        recipeListItems.Add("Fried Shrimp Sandwich", new List<string> {"Shrimp", "Bread Crumbs", "Hoagie Roll",
            "Romaine Lettuce", "Fresh Vegetables", "French Fries", "Pickle", "Ketchup"});

        recipeListItemsAmount.Add("Fried Shrimp Sandwich", new List<double> { 6, 2, 1, 1, 1, 1, 1, 1 });

        //***********************************************************************************************************
        //Grilled Halibut Recipe
        recipeListItems.Add("Grilled Halibut", new List<string> {"Halibut Filet", "Dry Spices", "Fresh Herbs",
            "Oil/Butter", "Rice", "Fresh Vegetables"});

        recipeListItemsAmount.Add("Grilled Halibut", new List<double> { 1, 1, 1, 2, 1, 2 });

        //***********************************************************************************************************
        //Grilled Pork Chops Recipe
        recipeListItems.Add("Grilled Pork Chops", new List<string> {"Pork Chops", "Dry Spices", "Fresh Herbs",
            "Oil/Butter", "Pasta", "Fresh Vegetables"});

        recipeListItemsAmount.Add("Grilled Pork Chops", new List<double> { 2, 1, 1, 2, 1, 2 });

        //***********************************************************************************************************
        //Grilled Shrimp Fettucine Alfredo Recipe
        recipeListItems.Add("Grilled Shrimp Fettucine Alfredo", new List<string> {"Shrimp", "Pasta",
            "Cream", "Parmesan Cheese", "Dry Spices", "Fresh Herbs", "Cooking Wine"});

        recipeListItemsAmount.Add("Grilled Shrimp Fettucine Alfredo", new List<double> { 6, 2, 2, 2, 1, 1, 1 });

        //***********************************************************************************************************
        //Hunter Chicken Recipe
        recipeListItems.Add("Hunter Chicken", new List<string> {"Half Chicken", "Oil/Butter", "Fresh Herbs",
            "Dry Spices", "Fresh Vegetables", "Cream", "Pasta", "Cooking Wine"});

        recipeListItemsAmount.Add("Hunter Chicken", new List<double> { 1, 2, 1, 1, 2, 1, 1, 2 });

        //***********************************************************************************************************
        //Lobster Ravioli Recipe
        recipeListItems.Add("Lobster Ravioli", new List<string> {"Lobster Ravioli", "Cream", "Oil/Butter",
            "Fresh Herbs", "Dry Spices", "Fresh Vegetables", "Cooking Wine"});

        recipeListItemsAmount.Add("Lobster Ravioli", new List<double> { 2, 2, 1, 1, 1, 1, 2 });

        //***********************************************************************************************************
        //Macaroni and Cheese Recipe
        recipeListItems.Add("Macaroni and Cheese", new List<string> {"Pasta", "Cream", "Dry Spices",
            "Fresh Herbs", "Cheddar Cheese", "Fresh Vegetables"});

        recipeListItemsAmount.Add("Macaroni and Cheese", new List<double> { 2, 3, 1, 1, 3, 1 });

        //***********************************************************************************************************
        //Meatloaf Recipe
        recipeListItems.Add("Meatloaf", new List<string> {"Ground Beef", "Bread Crumbs", "Fresh Herbs",
            "Dry Spices", "Potatoes", "Fresh Vegetables", "Oil/Butter"});

        recipeListItemsAmount.Add("Meatloaf", new List<double> { 2.5, 1, 1, 1, 1, 2, 2 });

        //***********************************************************************************************************
        //NY Strip Steak Recipe
        recipeListItems.Add("NY Strip Steak", new List<string> {"NY Strip Steak", "Oil/Butter", "Dry Spices",
            "Fresh Vegetables", "Fresh Herbs", "Potatoes"});

        recipeListItemsAmount.Add("NY Strip Steak", new List<double> { 2, 2, 1, 2, 1, 1 });

        //***********************************************************************************************************
        //Oven Roasted Half Chicken Recipe
        recipeListItems.Add("Oven Roasted Half Chicken", new List<string> {"Half Chicken", "Oil/Butter", "Dry Spices",
            "Fresh Vegetables", "Fresh Herbs", "Potatoes", "Cooking Wine"});

        recipeListItemsAmount.Add("Oven Roasted Half Chicken", new List<double> { 1, 2, 1, 2, 1, 1, 1 });

        //***********************************************************************************************************
        //Pork Schnitzel Recipe
        recipeListItems.Add("Pork Schnitzel", new List<string> {"Pork Chops", "Bread Crumbs", "Dry Spices",
            "Fresh Herbs", "Fresh Vegetables", "Oil/Butter", "Pasta"});

        recipeListItemsAmount.Add("Pork Schnitzel", new List<double> { 1.5, 1, 1, 1, 2, 2, 1 });

        //***********************************************************************************************************
        //Sauteed Chicken Breast Recipe
        recipeListItems.Add("Sauteed Chicken Breast", new List<string> {"Chicken Breast", "Dry Spices", "Fresh Herbs",
            "Fresh Vegetables", "Oil/Butter", "Rice", "Cooking Wine"});

        recipeListItemsAmount.Add("Sauteed Chicken Breast", new List<double> { 1.5, 1, 1, 2, 2, 1, 1 });

        //***********************************************************************************************************
        //Sauteed Duck Breast Recipe
        recipeListItems.Add("Sauteed Duck Breast", new List<string> {"Duck Breast", "Dry Spices", "Fresh Herbs",
            "Fresh Vegetables", "Oil/Butter", "Rice", "Cooking Wine"});

        recipeListItemsAmount.Add("Sauteed Duck Breast", new List<double> { 2, 1, 1, 2, 2, 1, 1 });

        //***********************************************************************************************************
        //Spaghetti and Meatballs Recipe
        recipeListItems.Add("Spaghetti and Meatballs", new List<string> {"Ground Beef", "Tomato Sauce", "Oil/Butter",
            "Fresh Herbs", "Dry Spices", "Bread Crumbs", "Parmesan Cheese", "Pasta"});

        recipeListItemsAmount.Add("Spaghetti and Meatballs", new List<double> { 1, 2, 1, 1, 1, 1, 1, 2 });

        //***********************************************************************************************************
        //Steak Sandwich Recipe
        recipeListItems.Add("Steak Sandwich", new List<string> {"NY Strip Steak", "Oil/Butter", "Dry Spices",
            "Hoagie Roll", "Fresh Vegetables", "French Fries", "Pickle"});

        recipeListItemsAmount.Add("Steak Sandwich", new List<double> { 1.5, 1, 1, 1, 1, 1, 1 });

        //***********************************************************************************************************
        //Ingredients cost list
        ingredientsCost.Add("Beef Filet", 4.25);
        ingredientsCost.Add("Bread Crumbs", 0.15);
        ingredientsCost.Add("Caesar Dressing", 0.12);
        ingredientsCost.Add("Cheddar Cheese", 0.15);
        ingredientsCost.Add("Chicken Breast", 1.25);
        ingredientsCost.Add("Chicken Tenders", 0.4);
        ingredientsCost.Add("Cooking Wine", 0.25);
        ingredientsCost.Add("Cream", 0.25);
        ingredientsCost.Add("Croutons", 0.17);
        ingredientsCost.Add("Dry Spices", 0.08);
        ingredientsCost.Add("Duck Breast", 1.65);
        ingredientsCost.Add("French Fries", 0.4);
        ingredientsCost.Add("Fresh Herbs", 0.29);
        ingredientsCost.Add("Fresh Vegetables", 0.3);
        ingredientsCost.Add("Ground Beef", 0.95);
        ingredientsCost.Add("Half Chicken", 2);
        ingredientsCost.Add("Halibut Filet", 4.75);
        ingredientsCost.Add("Hamburger Bun", 0.25);
        ingredientsCost.Add("Hoagie Roll", 0.35);
        ingredientsCost.Add("Hot Dog", 0.18);
        ingredientsCost.Add("Ketchup", 0.06);
        ingredientsCost.Add("Lobster Ravioli", 1.25);
        ingredientsCost.Add("Mozzarella Cheese", 0.15);
        ingredientsCost.Add("Nuts", 0.19);
        ingredientsCost.Add("NY Strip Steak", 1.75);
        ingredientsCost.Add("Oil/Butter", 0.11);
        ingredientsCost.Add("Parmesan Cheese", 0.17);
        ingredientsCost.Add("Pasta", 0.05);
        ingredientsCost.Add("Pickle", 0.09);
        ingredientsCost.Add("Pork Chops", 1.55);
        ingredientsCost.Add("Potatoes", 0.08);
        ingredientsCost.Add("Rice", 0.07);
        ingredientsCost.Add("Romaine Lettuce", 0.08);
        ingredientsCost.Add("Shrimp", 0.32);
        ingredientsCost.Add("Spicy Peanut Salad Dressing", 0.14);
        ingredientsCost.Add("Tomato Sauce", 0.27);


        //***********************************************************************************************************
        //Drink Item Cost
        drinksCost.Add("Beer/Wine", 0.9);
        drinksCost.Add("Chocolate Milk", 0.37);
        drinksCost.Add("Coffee", 0.15);
        drinksCost.Add("Iced Tea", 0.12);
        drinksCost.Add("Liquor", 1.1);
        drinksCost.Add("Soda", 0.05);

        //***********************************************************************************************************
        //Entrees Low Sweet Spot
        entreesLowSweetSpot.Add("Chicken Caesar Salad", 11.9);
        entreesLowSweetSpot.Add("Chicken Parmesan", 14.7);
        entreesLowSweetSpot.Add("Chinese Chicken Salad", 12.93);
        entreesLowSweetSpot.Add("Deluxe Hamburger", 9.9);
        entreesLowSweetSpot.Add("Filet Mignon", 27.5);
        entreesLowSweetSpot.Add("Foot Long Hotdog", 3.3);
        entreesLowSweetSpot.Add("Fried Chicken Tenders", 6.87);
        entreesLowSweetSpot.Add("Fried Shrimp Sandwich", 11.67);
        entreesLowSweetSpot.Add("Grilled Halibut", 18.75);
        entreesLowSweetSpot.Add("Grilled Pork Chops", 14.47);
        entreesLowSweetSpot.Add("Grilled Shrimp Fettucine Alfredo", 11.6);
        entreesLowSweetSpot.Add("Hunter Chicken", 13.3);
        entreesLowSweetSpot.Add("Lobster Ravioli", 14.27);
        entreesLowSweetSpot.Add("Macaroni and Cheese", 6.57);
        entreesLowSweetSpot.Add("Meatloaf", 12.65);
        entreesLowSweetSpot.Add("NY Strip Steak", 15.9);
        entreesLowSweetSpot.Add("Oven Roasted Half Chicken", 11.73);
        entreesLowSweetSpot.Add("Pork Schnitzel", 12.38);
        entreesLowSweetSpot.Add("Sauteed Chicken Breast", 11.28);
        entreesLowSweetSpot.Add("Sauteed Duck Breast", 15.5);
        entreesLowSweetSpot.Add("Spaghetti and Meatballs", 7.97);
        entreesLowSweetSpot.Add("Steak Sandwich", 12.95);


        //***********************************************************************************************************
        //Entrees High Sweet Spot
        entreesHighSweetSpot.Add("Chicken Caesar Salad", 12.5);
        entreesHighSweetSpot.Add("Chicken Parmesan", 15.75);
        entreesHighSweetSpot.Add("Chinese Chicken Salad", 13.25);
        entreesHighSweetSpot.Add("Deluxe Hamburger", 12.5);
        entreesHighSweetSpot.Add("Filet Mignon", 33.4);
        entreesHighSweetSpot.Add("Foot Long Hotdog", 7.5);
        entreesHighSweetSpot.Add("Fried Chicken Tenders", 7.75);
        entreesHighSweetSpot.Add("Fried Shrimp Sandwich", 12.75);
        entreesHighSweetSpot.Add("Grilled Halibut", 20.03);
        entreesHighSweetSpot.Add("Grilled Pork Chops", 16.25);
        entreesHighSweetSpot.Add("Grilled Shrimp Fettucine Alfredo", 14.75);
        entreesHighSweetSpot.Add("Hunter Chicken", 14.25);
        entreesHighSweetSpot.Add("Lobster Ravioli", 15.25);
        entreesHighSweetSpot.Add("Macaroni and Cheese", 8.25);
        entreesHighSweetSpot.Add("Meatloaf", 14.25);
        entreesHighSweetSpot.Add("NY Strip Steak", 16.25);
        entreesHighSweetSpot.Add("Oven Roasted Half Chicken", 13.25);
        entreesHighSweetSpot.Add("Pork Schnitzel", 14.5);
        entreesHighSweetSpot.Add("Sauteed Chicken Breast", 13.75);
        entreesHighSweetSpot.Add("Sauteed Duck Breast", 16.03);
        entreesHighSweetSpot.Add("Spaghetti and Meatballs", 14.75);
        entreesHighSweetSpot.Add("Steak Sandwich", 13.18);


        //***********************************************************************************************************
        //Setting variables for the size of the list and arrays
        ingredientsListSize = ingredientsList.Length;
}


    public int getIngredientsListSize()
    {
        return ingredientsListSize;
    }


    public List<string> getRecipeListItems(string recipe)
    {
        return recipeListItems[recipe];
    }


    public List<double> getRecipeListItemsAmount(string recipe)
    {
        return recipeListItemsAmount[recipe];
    }


    public double getIngredientsCost(string ingredient)
    {
        return ingredientsCost[ingredient];
    }


    public double getDrinksCost(string drink)
    {
        return drinksCost[drink];
    }


    public double getentreesLowSweetSpot(string entree)
    {
        return entreesLowSweetSpot[entree];
    }


    public double getentreesHighSweetSpot(string entree)
    {
        return entreesHighSweetSpot[entree];
    }


    public string getIngredientsList(int index)
    {
        return ingredientsList[index];
    }
}
