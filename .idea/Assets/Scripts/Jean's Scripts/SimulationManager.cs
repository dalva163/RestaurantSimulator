using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimulationManager : MonoBehaviour
{

    public float daySeconds;
    private float timer;

    public float days;

    private float currentTime = 0;
    public float limit;

    private float monthChecker;

    public bool simulateStarted;

    public Dropdown simDropdown;
    private UserLog userLog;

    private Button b;

    public Text text;

    private Restaurant_Script restaurant;
    private Demographics_Script demo;

    // Start is called before the first frame update
    void Start()
    {
        userLog = FindObjectOfType<UserLog>();
        demo = FindObjectOfType<Demographics_Script>();
        
        timer = 0;
        days = 0;
        monthChecker = 0;
        //limit = 7;
        simulateStarted = false;

        Debug.Log(simDropdown.value);
        text.text = "Day "+currentTime;

        restaurant = FindObjectOfType<Restaurant_Script>();

        //Button listener on the simulate button that starts the time simulation
        b = GetComponent<Button>();
        b.onClick.AddListener(delegate() { 

                if(!simulateStarted){
                    buttonStop(b);
                    userLog.logAction("User has started simulation");
                    userLog.displayRecentAction();
                    
                }else{
                    buttonSim(b);
                    userLog.logAction("User has stopped simulation after " +days+ " days");
                    userLog.displayRecentAction();
                }
                

                if(simDropdown.value == 0){
                    limit = 1;
                }else if(simDropdown.value == 1){
                    limit = 7;
                }
                else if(simDropdown.value == 2){
                    limit = 30;
                }
                else{
                    limit = 7;
                }
                //On button press, toggles the simulation on and off
                //Days are set to 0
                simulateStarted = !simulateStarted;
                days = 0;
                
            });
    }

    // Update is called once per frame
    void Update()
    {
        
        //Checks if the simulation has started
        if(simulateStarted){
            timer += Time.deltaTime;
            //If the timer reaches the set number of seconds, a day passes and the timer resets
            if (timer > daySeconds) {    
                timer = 0f;
                days++;
                currentTime ++;
                monthChecker++;

                demo.restaurantDay();
                restaurant.generateResults();
                print ("Day "+days+ " done");
            }
        }

        //If days reach simulation limit, simulation ends and days reset
        if(days >= limit){
            simulateStarted = false;
            days = 0;
            buttonSim(b);
            userLog.logAction("Program has stopped simulation after " +limit+ " days");
            userLog.displayRecentAction();
        }

        if(monthChecker >= 30)
        {
            monthChecker = 0;
            //restaurant.generateResults();
            restaurant.deductBuildingLease();
            restaurant.updateCapital();
            restaurant.displayCapital();
        }

        text.text = "Day "+currentTime;
        
    }

    void buttonStop(Button b){
        //Changes the simulate button into a stop button
        b.GetComponentInChildren<Text>().text = "Stop";
        b.GetComponent<Image>().color = Color.red;
    }

    void buttonSim(Button b){
        //Changes the stop button into a simulate button
        b.GetComponentInChildren<Text>().text = "Simulate";
        b.GetComponent<Image>().color = Color.green;
    }

    
}
