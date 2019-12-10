using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalSell : MonoBehaviour
{

    public GameObject SellDisplay;
    public static int costo=5;
    int mostrarCosto;
    // Update is called once per frame
    void Update()
    {
        mostrarCosto = costo;
       SellDisplay.GetComponent<Text>().text = "Valor mejora: " + mostrarCosto;

    }
}
