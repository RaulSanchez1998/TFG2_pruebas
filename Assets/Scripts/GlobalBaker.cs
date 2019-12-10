using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int bakerValue=50;
    public static bool turnOffButton = false;
    public GameObject bakerStats;
    public static int numberBakers;
    public static int bakePerSec;
    
    

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount; //Hace referencia a la variable 
        bakerStats.GetComponent<Text>().text = "Bakers: " + numberBakers + " @ " + bakePerSec + " PerSecond";
        fakeText.GetComponent<Text>().text = "Buy Baker - $" + bakerValue;
        realText.GetComponent<Text>().text = "Buy Baker - $" + bakerValue;
        if (currentCash >= bakerValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        if(currentCash<= bakerValue)
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }

        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
