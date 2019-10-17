using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    private Menu menu;

    public GameObject subpanel;
    // Start is called before the first frame update
    void Start()
    {
        menu = FindObjectOfType<Menu>();
        Button b = GetComponent<Button>();

        b.onClick.AddListener(delegate(){

            Debug.Log("Button pressed"); 
            menu.setCurrentSubpanel(subpanel);

        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
