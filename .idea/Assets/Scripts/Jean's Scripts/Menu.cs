using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject menu_panel;
    public GameObject currentSubpanel;
    public bool isOn;
   

    public int currentTextbox;

    //Dictionary<string,float> playerMenu;
    //private string [] playerMenu;
    private ArrayList playerMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        isOn = true;
        currentTextbox = 0;
        Button b = gameObject.GetComponent<Button>();
        //playerMenu = new Dictionary<string,float>();
        playerMenu = new ArrayList();
        b.onClick.AddListener(delegate() { 

                isOn = !isOn;

                if(!isOn){
                    Debug.Log("Menu is open");
                    menu_panel.SetActive(true);
                    currentSubpanel.SetActive(true);
                }
                else{
                    Debug.Log("Menu is closed");
                    menu_panel.SetActive(false);
                    currentSubpanel.SetActive(false);
                }

                Debug.Log(playerMenu.Count);
                
                
            
            });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setCurrentSubpanel(GameObject subpanel){
        currentSubpanel.SetActive(false);
        this.currentSubpanel = subpanel;
        currentSubpanel.SetActive(true);
    }

    public void addItem(object item){
        playerMenu.Add(item);
    }

    public void incrementTextbox(){
        currentTextbox++;
    }

    public int getTexboxNum(){
        return currentTextbox;
    }

    public void decrementTextbox(){
        currentTextbox--;
    }

    public void setTextboxNum(int num){
        currentTextbox = num;
    }
}
