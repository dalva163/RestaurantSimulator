using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonController : MonoBehaviour
{
    public GameObject entreePanel;
    public GameObject drinkPanel;

    public GameObject menuEntreePanel;
    public GameObject menuDrinkPanel;

    private MenuItem menuItem;

    public bool IsDrink;

    public bool isEntree;

    
    // Start is called before the first frame update
    void Start()
    {
        isEntree = true;
        Button b = gameObject.GetComponent<Button>();
        menuItem = FindObjectOfType<MenuItem>();
        b.onClick.AddListener(delegate() { 

                if(!IsDrink){
                    entreePanel.SetActive(true);
                    menuEntreePanel.SetActive(true);
                    menuDrinkPanel.SetActive(false);
                    drinkPanel.SetActive(false);
                    //isEntree = true;
                    //menuItem.setDrink(false);
                } 
                else{
                    entreePanel.SetActive(false);
                    menuEntreePanel.SetActive(false);
                    menuDrinkPanel.SetActive(true);
                    drinkPanel.SetActive(true);
                    //isEntree = false;
                    //menuItem.setDrink(true);
                }   
                
                
            });
    }

    // Update is called once per frame
    void Update()
    {
        if(menuEntreePanel.activeSelf == true){
            isEntree = true;
        }else{
            isEntree = false;
        }
    }

    public void setEntree(bool result){
        isEntree = result;
    }

    public bool getEntree(){
        return isEntree;
    }


}
