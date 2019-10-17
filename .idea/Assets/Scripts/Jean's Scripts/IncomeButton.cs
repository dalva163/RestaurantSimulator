using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncomeButton : MonoBehaviour
{
    private Button income;
    public GameObject results;

    private bool active;
    // Start is called before the first frame update
    void Start()
    {
        income = GetComponent<Button>();

        income.onClick.AddListener(delegate(){
            active = !active;
            results.SetActive(active);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
