using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserLog : MonoBehaviour
{
    private List<string> userActions = new List<string>();

    public GameObject userPanel;
    public Text logText;
    public Button logButton;

    public bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
        logButton.onClick.AddListener(delegate(){
            isOpen = !isOpen;

            if(isOpen){
                userPanel.SetActive(true);
            }
            else{
                userPanel.SetActive(false);
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void logAction(string action){
        userActions.Add(action);
        logText.text += action + "\n";
    }

    public void displayActions(){
        for(int i = 0; i < userActions.Count; i++){
            Debug.Log(userActions[i]);
        }
    }

    public void displayRecentAction(){
        int listSize = userActions.Count - 1;
        Debug.Log(userActions[listSize]);
    }
}
