using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    private RestaurantClass restaurant;
    public int textNum;
    public bool isEntree;

    public bool isSelected;

    public bool isPicked;

    public string item;

    MenuItem menuItem;

    Text text;
    // Start is called before the first frame update
    
    //private Text text;
    void Start()
    {
        
        menuItem = FindObjectOfType<MenuItem>();
        restaurant = new RestaurantClass();
        Button b = GetComponentInChildren<Button>();
        Button add = FindObjectOfType<AddButton>().GetComponent<Button>();

        b.onClick.AddListener(delegate() { 
            
            menuItem.setSelectedString(item);
            
                
        });

        add.onClick.AddListener(delegate(){

            if(menuItem.getSelectedString().Equals(item)){
                menuItem.setPicked(true);
            }
            

        });
        
        if(isEntree){
            item = restaurant.getMenuListItem(textNum);
            GetComponent<Text>().text = restaurant.getMenuListItem(textNum);
            
        }
        else{
            item = restaurant.getDrinksListItem(textNum);
            GetComponent<Text>().text = restaurant.getDrinksListItem(textNum);
            
        }
        
        
        

        
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
