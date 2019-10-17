using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("It ran");
        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(delegate() { Debug.Log("Button pressed"); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
