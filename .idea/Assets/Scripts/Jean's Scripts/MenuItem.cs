using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuItem : MonoBehaviour
{
    public static string selectedString;
    public int textBoxNum;
    public bool isDrink;

    public bool isPicked;

    private Menu menu;
    private MenuButtonController menuButton;
    private MenuItemClass selectedItem;
    private RestaurantFineDining restaurantMenu;
    private Restaurant_Script restaurant;
    private MenuListPrices menuListPrices;
    

    private MenuItemClass[] e = new MenuItemClass[10];

    public int currentEntreeBox;
    public int currentDrinkBox;
    // Start is called before the first frame update
    void Start()
    {
        currentEntreeBox = 0;
        currentDrinkBox = 100;
        Button b = FindObjectOfType<AddButton>().GetComponent<Button>();
        Button d = FindObjectOfType<DeleteButton>().GetComponent<Button>();
        Button u = FindObjectOfType<UpdateButton>().GetComponent<Button>();
        
        AddButton add = FindObjectOfType<AddButton>();
        menuButton = FindObjectOfType<MenuButtonController>();
        menuListPrices = FindObjectOfType<MenuListPrices>();
        restaurantMenu = new RestaurantFineDining();
        restaurant = FindObjectOfType<Restaurant_Script>();
        menu = FindObjectOfType<Menu>();

        

        //Button listener for the add button
        b.onClick.AddListener(delegate() { 
                
                ////Debug.Log("Current: "+currentEntreeBox+" textbox: "+textBoxNum);
                
                if(menuButton.getEntree() && !selectedString.Equals("")){
                    if(textBoxNum == currentEntreeBox){
                        GetComponent<Text>().text = selectedString;
                        selectedItem = new MenuItemClass(selectedString);
                        
                        restaurant.addEntreeToMenu(selectedItem,currentEntreeBox);
                        restaurant.entreePopularity(currentEntreeBox);
                        restaurant.setItemIngredientsCost(selectedString, currentEntreeBox);
                        
                        
                    }
                    currentEntreeBox++;
                }
                else{
                    if(textBoxNum == currentDrinkBox){
                        GetComponent<Text>().text = selectedString;
                        selectedItem = new MenuItemClass(selectedString);
                        
                        restaurant.addDrinkToMenu(selectedItem, currentDrinkBox - 100);
                        restaurant.drinkPopularity(currentDrinkBox - 100);
                        restaurant.setItemDrinksCost(selectedString, currentDrinkBox - 100);
                        
                        
                }
                    currentDrinkBox++;
                }

                
                          
            });

        //Button listener for the delete button
        d.onClick.AddListener(delegate(){



        });
        
        u.onClick.AddListener(delegate(){
            
            menuListPrices.updateMenu();
            //restaurantMenu.getEntreeMenu();
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setSelectedString(string selected){
        selectedString = selected;
    }

    public string getSelectedString(){
        return selectedString;
    }

    public void setCurrentTextbox(int current){
        currentEntreeBox = current;
    }

    public void setPicked(bool picked){
        this.isPicked = picked;
    }

   
}
