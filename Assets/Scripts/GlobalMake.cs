using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMake : MonoBehaviour
{
   public GameObject MakeDisplay;
    public static int costo=5;
    int mostrarCosto;
     // Update is called once per frame
    void Update()
    {
         mostrarCosto = costo;
        MakeDisplay.GetComponent<Text>().text = "Valor mejora: " + mostrarCosto;

    }
}
