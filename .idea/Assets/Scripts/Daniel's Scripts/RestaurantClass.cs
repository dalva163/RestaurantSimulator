using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestaurantClass
{

    private string[] staffJobs = {"FOH Manager", "BOH Manager", "FOH Host", "FOH Bartender",
        "FOH Busser", "FOH Server", "BOH Cook", "BOH Dishwasher"}; //FOH = Front of the house | BOH = Back of the house

    private double capital; //amount of money the player has

    //Catered Demographic
    protected string cateredDemographic = "Business"; //business, leisure or family

    private string[] menuList = {"Chicken Caesar Salad", "Chicken Parmesan", "Chinese Chicken Salad",
        "Deluxe Hamburger", "Filet Mignon", "Foot Long Hotdog", "Fried Chicken Tenders", "Fried Shrimp Sandwich",
        "Grilled Halibut", "Grilled Pork Chops", "Grilled Shrimp Fettucine Alfredo", "Hunter Chicken", "Lobster Ravioli",
        "Macaroni and Cheese", "Meatloaf", "NY Strip Steak", "Oven Roasted Half Chicken", "Pork Schnitzel",
        "Sauteed Chicken Breast", "Sauteed Duck Breast", "Spaghetti and Meatballs", "Steak Sandwich"};

    private string[] drinksList = {"Beer/Wine", "Coffee", "Chocolate Milk" , "Iced Tea", "Liquor", "Soda"};

    private int menuListCount;
    private int menuDrinksListCount;

    private int entreeCount;
    private int drinkCount;



    //**********************************************************************************************************************************
    //Players menu layout, Players Selling Price and Popularity Index
    protected MenuItemClass[] entreesMenuLayout = new MenuItemClass[10];
    protected MenuItemClass[] drinksMenuLayout = new MenuItemClass[5];

    protected IngredientsClass allIngredientsInfo;

    private ResultsClass results;


    public RestaurantClass()
    {
        capital = 20000;
        menuListCount = menuList.Length;
        menuDrinksListCount = drinksList.Length;

        entreeCount = 0;
        drinkCount = 0;

        allIngredientsInfo = new IngredientsClass();
    }

    

    public void updateCapital(){
        capital += results.getProfit();
    }


    public ResultsClass getResults()
    {
        return results;
    }

    public void createResultsClass(string type)
    {
        results = new ResultsClass(type);
    }

    public int getEntreesSize(){
        return entreesMenuLayout.Length;
    }

    public int getDrinksSize(){
        return drinksMenuLayout.Length;
    }

    public void setEntreesMenuLayout(MenuItemClass entreesMenuLayout, int index)
    {
        this.entreesMenuLayout[index] = entreesMenuLayout;
        entreeCount++;
        Debug.Log("Amount of entrees:" +entreeCount);
    }

    public void setDrinksMenuLayout(MenuItemClass drinksMenuLayout, int index)
    {
        this.drinksMenuLayout[index] = drinksMenuLayout;
        drinkCount++;
        Debug.Log("Amount of drinks:" +drinkCount);
    }

    public MenuItemClass getEntreesMenuLayout(int index){
        return this.entreesMenuLayout[index];
    }

    public MenuItemClass[] getEntreeMenu(){
        return this.entreesMenuLayout;
    }

    public MenuItemClass getDrinksMenuLayout(int index){
        return this.drinksMenuLayout[index];
    }

    public int getMenuListCount()
    {
        return menuListCount;
    }

    public int getMenuDrinksListCount()
    {
        return menuDrinksListCount;
    }

    public string getMenuListItem(int index)
    {
        return menuList[index];
    }

    public string getDrinksListItem(int index){
        return drinksList[index];
    }

    public void setCapital(double capital)
    {
        this.capital = capital;
    }

    public double getCapital()
    {
        return capital;
    }

    public void setCateredDemographic(string cateredDemographic)
    {
        this.cateredDemographic = cateredDemographic;
    }

    public string getCateredDemographic()
    {
        return cateredDemographic;
    }


    public void debugLogMenuList()
    {
        for (int i = 0; i < entreesMenuLayout.Length; i++)
        {
            Debug.Log(entreesMenuLayout[i].getItemName());
        }

        for (int i = 0; i < drinksMenuLayout.Length; i++)
        {
            Debug.Log(drinksMenuLayout[i].getItemName());
        }
    }

    public void testArrayEntree(int index){
        Debug.Log(entreesMenuLayout[index].getItemName());
        Debug.Log(entreesMenuLayout[index].getItemPrice());
    }

    public void testArrayDrinks(int index){
        Debug.Log(drinksMenuLayout[index].getItemName());
        Debug.Log(drinksMenuLayout[index].getItemPrice());
    }

    public bool isDuplicateEntree(string selectedString){

        Debug.Log(selectedString);
        if(entreesMenuLayout.Length == 0){
            return false;
        }

        for(int i = 0; i < entreesMenuLayout.Length; i++){
            if(entreesMenuLayout[i].getItemName().Equals(selectedString)){
                return true;
            }

        }

         return false;

    }

    public bool isDuplicateDrink(string selectedString){

        if(drinksMenuLayout.Length == 0){
            return false;
        }

        for(int i = 0; i < drinksMenuLayout.Length; i++){
            // if(drinksMenuLayout[i].getItemName().Equals(selectedString)){
            //     return true;
            // }
        }

        return false;

    }


    //Checks if the selling price hits the sweet spot range to give it a percent or decrease the percent
    public void pricingSweetSpot(string entree, int menuItemIndex)
    {
        if((entreesMenuLayout[menuItemIndex].getItemPrice() >= allIngredientsInfo.getentreesLowSweetSpot(entree)) && (entreesMenuLayout[menuItemIndex].getItemPrice() <= allIngredientsInfo.getentreesHighSweetSpot(entree)))
        {
            entreesMenuLayout[menuItemIndex].setSweetSpot(0.05);
            Debug.Log("Sweetspot hit");
        }
        else if(entreesMenuLayout[menuItemIndex].getItemPrice() < allIngredientsInfo.getentreesLowSweetSpot(entree))
        {
            entreesMenuLayout[menuItemIndex].setSweetSpot(0.1);
            Debug.Log("Neutral");
        }
        else if(entreesMenuLayout[menuItemIndex].getItemPrice() > allIngredientsInfo.getentreesHighSweetSpot(entree) * 2)
        {
            entreesMenuLayout[menuItemIndex].setSweetSpot(-0.5);
            Debug.Log("Way OFF!");
            
        }
        else if(entreesMenuLayout[menuItemIndex].getItemPrice() > allIngredientsInfo.getentreesHighSweetSpot(entree))
        {
            entreesMenuLayout[menuItemIndex].setSweetSpot(-0.1);
            Debug.Log("Penalty Added");
        }
    }

    //item cost for the entree selected
    public void setItemIngredientsCost(string entree, int index)
    {
        double total = 0;

        List<string> ingredients = allIngredientsInfo.getRecipeListItems(entree);
        List<double> ingredientsAmount = allIngredientsInfo.getRecipeListItemsAmount(entree);

        for(int i = 0; i < ingredients.Count; i++)
        {
            //Debug.Log("Ingredients "+ i+ " "+ ingredients[i]);
            total = total + (ingredientsAmount[i] * allIngredientsInfo.getIngredientsCost(ingredients[i]));
        }
        entreesMenuLayout[index].setItemIngredientsCost(total);
    }


    public void setItemDrinksCost(string drink, int index)
    {
        drinksMenuLayout[index].setItemIngredientsCost(allIngredientsInfo.getDrinksCost(drink));
    }


    public void generateResults()
    {
        for (int i = 0; i < entreeCount; i++)
        {
            entreesMenuLayout[i].generateReport();
        }

        for (int i = 0; i < drinkCount; i++)
        {
            drinksMenuLayout[i].generateReport();
        }

        results.generateFoodAndDrinksCost(entreesMenuLayout, drinksMenuLayout, entreeCount, drinkCount);
        results.generateFoodAndDrinksRevenue(entreesMenuLayout, drinksMenuLayout, entreeCount, drinkCount);
        results.generateGrossMargin();
        results.generateProfit();
        results.generateTotalItemsSold(entreesMenuLayout, drinksMenuLayout, entreeCount, drinkCount);
    }
}
