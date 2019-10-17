using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(delegate() { Debug.Log("Button pressed"); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
