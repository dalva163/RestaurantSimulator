using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionController : MonoBehaviour
{
    // Start is called before the first frame update
    private Actions actions;
    public GameObject subpanel;
    void Start()
    {
        actions = FindObjectOfType<Actions>();
        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(delegate() { 
                Debug.Log("Button pressed"); 
                actions.setCurrentSubpanel(subpanel);
                //Instantiate(action_menu, subpanel.transform.position, subpanel.transform.rotation);
                
            
            });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
