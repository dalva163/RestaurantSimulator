using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restaurant_Script : MonoBehaviour
{
    public Text capital;
    public Text customers;
    public Text reviews;
    public Text ordersServed;
    public Text restaurantType;

    public GameObject restaurantCreationPanel;

    public Button creation;

    private RestaurantClass restaurant;
    private RestaurantFineDining fineDining;
    private RestaurantCasualDining casualDining;
    private RestaurantRelaxedUpscale relaxedUpscale;
    private UserLog userLog;


    private int entreeCount;
    private int drinkCount;

    private int inside;
    private int outside;
    private int customersIn;
    private int orders;

    private float reviewAverage;
    private float reviewTotal;

    private string type;
    private string targetDem;
    public string levelToLoad;

    private double percentagePool;


    public Toggle fineToggle;
    public Toggle casualToggle;
    public Toggle relaxedToggle;

    public Toggle businessToggle;
    public Toggle leisureToggle;
    public Toggle familyToggle;
    // Start is called before the first frame update
    void Start()
    {
        fineDining = new RestaurantFineDining();
        casualDining = new RestaurantCasualDining();
        relaxedUpscale = new RestaurantRelaxedUpscale();
        userLog = FindObjectOfType<UserLog>();

        restaurant = fineDining;

        entreeCount = 0;
        drinkCount = 0;

        inside = 0;
        outside = 0;
        
        displayCapital();

        creation.onClick.AddListener(delegate(){

            if(fineToggle.isOn){
                type = "Fine Dining";
            }
            else if(casualToggle.isOn){
                type = "Casual Dining";
            }
            else if(relaxedToggle.isOn){
                type = "Relaxed Upscaled";
            }
            else{
                type = "Casual Dining";
            }

            if(businessToggle.isOn){
                targetDem = "Business";
            }
            else if(leisureToggle.isOn){
                targetDem = "Leisure";
            }
            else if(familyToggle.isOn){
                targetDem = "Family";
            }
            else{
                targetDem = "Family";
            }

            Debug.Log("Works");
            setRestaurantType(type);
            setTargetDemographic(targetDem);
            restaurantType.text = type;

            restaurantCreationPanel.SetActive(false);

        });
        
    }

    public void displayCapital(){
        capital.text = restaurant.getCapital().ToString();
    }

    public void updateCapital(){
        restaurant.updateCapital();
    }

    public void updateCustomers(){
        customers.text = customersIn.ToString();
    }

    public void updateOrders(){
        ordersServed.text = orders.ToString();
    }

    public void updateReviews(){
        reviews.text = reviewAverage.ToString("F1");
    }


    public void generateResults(){
        restaurant.generateResults();
    }

    public void setRestaurantType(string type){
        if(type.Equals("Fine Dining")){
            restaurant = fineDining;
            Debug.Log("Fine Dining");
            userLog.logAction("User selected to run a fine dining restaurant");
            userLog.displayRecentAction();
            
              
        }
        else if(type.Equals("Casual Dining")){
            restaurant = casualDining;
            Debug.Log("Casual Dining");
            userLog.logAction("User selected to run a casual dining restaurant");
            userLog.displayRecentAction();
            
        }
        else if(type.Equals("Relaxed Upscaled")){
            restaurant = relaxedUpscale;
            Debug.Log("Relaxed");
            userLog.logAction("User selected to run a relaxed upscale dining restaurant");
            userLog.displayRecentAction();
            
        }
        else{
            Debug.Log("WTF");
        }

        restaurant.createResultsClass(type);
    }

    public void setTargetDemographic(string type){
        restaurant.setCateredDemographic(type);
    }

    public void addEntreeToMenu(MenuItemClass item, int index){

        restaurant.setEntreesMenuLayout(item, index);
        Debug.Log("Item name: "+item.getItemName()+ " added");
        userLog.logAction("User adds "+ item.getItemName() + " to the entree menu");
        userLog.displayRecentAction();
        entreeCount++;

    }

    public void addDrinkToMenu(MenuItemClass item, int index){
        restaurant.setDrinksMenuLayout(item, index);
        Debug.Log("Item name: "+item.getItemName()+ " added");
        userLog.logAction("User adds "+ item.getItemName() + " to the drink menu");
        userLog.displayRecentAction();
        drinkCount++;
    }

    public void entreePopularity(int index){
        if(type.Equals("Fine Dining")){
            fineDining.rankPopularityIndexEntrees(index);
           
        }
        else if(type.Equals("Casual Dining")){
            casualDining.rankPopularityIndexEntrees(index);
            
        }
        else if(type.Equals("Relaxed Upscaled")){
            relaxedUpscale.rankPopularityIndexEntrees(index);
            
        }
        else{
            Debug.Log("WTF");
        }
        
    }

    public void drinkPopularity(int index){
        if(type.Equals("Fine Dining")){
            fineDining.rankPopularityIndexDrinks(index);
        }
        else if(type.Equals("Casual Dining")){
            casualDining.rankPopularityIndexDrinks(index);
        }
        else if(type.Equals("Relaxed Upscaled")){
            relaxedUpscale.rankPopularityIndexDrinks(index);
        }
        else{
            Debug.Log("WTF");
        }
    }

    public void updateEntreePrice(int index, double price){
        restaurant.getEntreesMenuLayout(index).setItemPrice(price);
        userLog.logAction("User updated menu price for "+restaurant.getEntreesMenuLayout(index).getItemName() +" to "+ restaurant.getEntreesMenuLayout(index).getItemPrice());
        userLog.displayRecentAction();
    }

    public MenuItemClass getEntree(int index){
        return restaurant.getEntreesMenuLayout(index);
    }

    public void updateDrinkPrice(int index, double price){
        restaurant.getDrinksMenuLayout(index).setItemPrice(price);
        userLog.logAction("User updated menu price for "+restaurant.getDrinksMenuLayout(index).getItemName() +" to "+ restaurant.getDrinksMenuLayout(index).getItemPrice());
        userLog.displayRecentAction();
    }

    public MenuItemClass getDrink(int index){
        return restaurant.getDrinksMenuLayout(index);
    }

    public int getEntreeSize(){
        return entreeCount;
    }

    public int getDrinkSize(){
        return drinkCount;
    }

    public void pricingSweetSpot(string entree, int menuItemIndex){
        restaurant.pricingSweetSpot(entree,menuItemIndex);
    }

    public void setItemIngredientsCost(string selectedString, int currentEntreeBox){
        restaurant.setItemIngredientsCost(selectedString, currentEntreeBox);
    }

    public void setItemDrinksCost(string selectedString, int currentDrinkBox){
       restaurant.setItemDrinksCost(selectedString, currentDrinkBox);
    }

    public ResultsClass getResultsInfo(){
        return restaurant.getResults();
    }

    public void deductBuildingLease()
    {
        restaurant.getResults().deductBuildingLease();
    }

    public void getInsideRestaurant(Household household){
        
        if(type.Equals("Fine Dining")){
            if(household.getHouseholdType().Equals("Business")){
                household.addBasePercentage(0.15f);
            }
            else if(household.getHouseholdType().Equals("Leisure")){
                household.subtractBasePercentage(0.05f);
            }
            else if(household.getHouseholdType().Equals("Family")){
                household.subtractBasePercentage(0.10f);
            }
        }
        else if(type.Equals("Relaxed Upscaled")){
            if(household.getHouseholdType().Equals("Business")){
                household.subtractBasePercentage(0.05f);
            }
            else if(household.getHouseholdType().Equals("Leisure")){
                household.addBasePercentage(0.15f);
            }
            else if(household.getHouseholdType().Equals("Family")){
                household.subtractBasePercentage(0.05f);
            }
        }
        else if(type.Equals("Casual Dining")){
            if(household.getHouseholdType().Equals("Business")){
                household.subtractBasePercentage(0.10f);
            }
            else if(household.getHouseholdType().Equals("Leisure")){
                household.subtractBasePercentage(0.05f);
            }
            else if(household.getHouseholdType().Equals("Family")){
                household.addBasePercentage(0.15f);
            }
        }

        int chance = Random.Range(1, 101);

        if(chance <= household.getBasePercentage() * 100){
            //Debug.Log("Household went inside");
            inside++;
            Debug.Log("Household size: "+household.getTotalPeople());

            

            for(int i = 0; i < household.getTotalPeople(); i++){
                customersIn++;
                updateCustomers();
                chooseEntree();
                chooseDrink();

                float score = Random.Range(1,11);
                Debug.Log("Score: "+score);
                reviewTotal += score;
                reviewAverage = reviewTotal/customersIn;
                updateReviews();
            }
        }else{
            //Debug.Log("Household did not go inside restaurant");
            outside++;
        }

        //restaurant.generateResults();
        //Debug.Log("Household did go inside restaurant: "+ inside);
        //Debug.Log("Households did not go inside restaurant: "+ outside);

        //Debug.Log("Customers: "+ customersIn);
        
    }

    public int chooseEntree(){
        for(int i = 0; i < entreeCount; i++){
            //Debug.Log("Percent "+getEntree(i).getTotalPercentage());
            double percent = getEntree(i).getTotalPercentage();
            int entreeChance = Random.Range(1, 101);

            Debug.Log("Percent: "+percent);

            if(entreeChance < percent * 100){
                Debug.Log(getEntree(i).getItemName()+ " was bought.");
                getEntree(i).itemBuy();
                
                Debug.Log("Items sold: "+getEntree(i).getQtySold());
                orders++;

                
                updateOrders();
                //restaurant.generateResults();
                return 0;
            }

        }
        return 1;
    }

    public int chooseDrink(){
        for (int i = 0; i < drinkCount; i++)
        {
            //Debug.Log("Percent "+getEntree(i).getTotalPercentage());
            double percent = getDrink(i).getTotalPercentage();
            int drinkChance = Random.Range(1, 101);

            if (drinkChance < percent * 100)
            {
                Debug.Log(getDrink(i).getItemName() + " was bought.");
                getDrink(i).itemBuy();
                Debug.Log("Items sold: "+getDrink(i).getQtySold());
                orders++;
                updateOrders();
                return 0;
            }

        }
        return 1;
    }

    public void getPercentages(){
        for(int i = 0; i < entreeCount; i++){
            double percent = getEntree(i).getTotalPercentage();
            percentagePool += percent;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Restart")){
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
