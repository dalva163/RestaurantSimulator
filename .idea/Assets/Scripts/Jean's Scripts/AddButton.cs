using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddButton : MonoBehaviour
{
    public int currentTextbox;
    MenuItem menu;

    public Dropdown simDropdown;
    // Start is called before the first frame update
    void Start()
    {
        menu = FindObjectOfType<MenuItem>();
        currentTextbox = 0;
        Button b = GetComponent<Button>();
        
        b.onClick.AddListener(delegate() { 
                
                //menu.setCurrentTextbox(currentTextbox);
                //currentTextbox++;
                
            });
    }

    public int getCurrentTextbox(){
        return currentTextbox;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
