using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actions : MonoBehaviour
{
    public GameObject action_menu;
    public GameObject currentSubpanel;

    public bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        isOn = true;
        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(delegate() { 
                isOn = !isOn;

                if(!isOn){
                    Debug.Log("Menu opened"); 
                    action_menu.SetActive(true);
                    currentSubpanel.SetActive(true);
                }
                else{
                    Debug.Log("Menu closed"); 
                    action_menu.SetActive(false);
                    currentSubpanel.SetActive(false);
                }
                
                //Instantiate(action_menu, subpanel.transform.position, subpanel.transform.rotation);
                
            
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
    
    
}
