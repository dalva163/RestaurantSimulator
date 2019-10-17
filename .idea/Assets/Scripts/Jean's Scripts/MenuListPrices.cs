using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuListPrices : MonoBehaviour
{
    public List<Text> menuEntreeItem = new List<Text>();

    public List<Text> menuDrinkItem = new List<Text>();
    

    private List<MenuItemClass> entrees = new List<MenuItemClass>();

    private List<MenuItemClass> drinks = new List<MenuItemClass>();

    public Text entree1;
    public Text entree2;
    public Text entree3;
    public Text entree4;
    public Text entree5;
    public Text entree6;
    public Text entree7;
    public Text entree8;
    public Text entree9;
    public Text entree10;

    public Text drink1;
    public Text drink2;
    public Text drink3;
    public Text drink4;
    public Text drink5;
   
    private Restaurant_Script restaurant;
    private UserLog userLog;

    public Button updatePrices;
    // Start is called before the first frame update
    void Start()
    {
        //restaurant = new RestaurantClass();

        //Button u = FindObjectOfType<UpdateButton>().GetComponent<Button>();

        menuEntreeItem.Add(entree1);
        menuEntreeItem.Add(entree2);
        menuEntreeItem.Add(entree3);
        menuEntreeItem.Add(entree4);
        menuEntreeItem.Add(entree5);
        menuEntreeItem.Add(entree6);
        menuEntreeItem.Add(entree7);
        menuEntreeItem.Add(entree8);
        menuEntreeItem.Add(entree9);
        menuEntreeItem.Add(entree10);

        menuDrinkItem.Add(drink1);
        menuDrinkItem.Add(drink2);
        menuDrinkItem.Add(drink3);
        menuDrinkItem.Add(drink4);
        menuDrinkItem.Add(drink5);

        restaurant = FindObjectOfType<Restaurant_Script>();
        userLog = FindObjectOfType<UserLog>();

        updatePrices.onClick.AddListener(delegate(){

            Debug.Log("Update prices works");
            updateEntreePrices();
            updateDrinkPrices();

        });
    }

    // Update is called once per frame
    void Update()
    {
        //updateMenu();
        //updateEntreePrices();
    }

    public void updateMenu(){
        for(int i = 0; i < restaurant.getEntreeSize(); i++){
            Debug.Log(restaurant.getEntreeSize());
            menuEntreeItem[i].GetComponent<Text>().text = restaurant.getEntree(i).getItemName();
            //Debug.Log(menuitem[i].GetComponent<Text>());
        }

        for(int i = 0; i < restaurant.getDrinkSize(); i++){
            menuDrinkItem[i].GetComponent<Text>().text = restaurant.getDrink(i).getItemName();
        }

        //userLog.logAction("User updated menu list");
        userLog.displayRecentAction();
    }

    public void updateEntreePrices(){
        double result;
        for(int i = 0; i < restaurant.getEntreeSize(); i++){
            
            double.TryParse(menuEntreeItem[i].GetComponentInChildren<InputField>().text, out result);
            //entrees[i].setItemPrice(result);
            restaurant.updateEntreePrice(i,result);
            restaurant.pricingSweetSpot(restaurant.getEntree(i).getItemName(), i);
            restaurant.getEntree(i).addPercentages();
            Debug.Log("Name: "+restaurant.getEntree(i).getItemName()+ " Price: " + restaurant.getEntree(i).getItemPrice());

        }
        
    }

    public void updateDrinkPrices(){
        double result;
        for(int i = 0; i < restaurant.getDrinkSize(); i++){
            
            double.TryParse(menuDrinkItem[i].GetComponentInChildren<InputField>().text, out result);
            //drinks[i].setItemPrice(result);
            restaurant.updateDrinkPrice(i, result);
            Debug.Log("Name: "+restaurant.getDrink(i).getItemName()+ " Price: " + restaurant.getDrink(i).getItemName());
        }
        
    }

    

    public void setEntrees(MenuItemClass selectedItem){
        entrees.Add(selectedItem);
    }

    public void setDrinks(MenuItemClass selectedItem){
        drinks.Add(selectedItem);
    }
}
