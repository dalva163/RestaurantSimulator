using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMix : MonoBehaviour
{

    public List<Text> menuEntreeItem = new List<Text>();

    public List<Text> menuDrinkItem = new List<Text>();

    private Restaurant_Script restaurant;

    public Button mix;

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

    // Start is called before the first frame update
    void Start()
    {
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

        mix.onClick.AddListener(delegate(){
            
        });
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateMenuColumn(){

    }
}
