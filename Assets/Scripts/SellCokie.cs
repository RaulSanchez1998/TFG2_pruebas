using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Tiene que tener el mismo nombre que el script obvio
public class SellCokie : MonoBehaviour
{
    //Declarar variables
    public GameObject  textBox;
    public GameObject statusBox;
    public int venta = 1;
  
    public void ClickTheButton()
    {
        if (GlobalCookies.CookieCount != 0)
        {
            GlobalCookies.CookieCount -= 1;
            GlobalCash.CashCount += venta;
        }
        else
        {
            statusBox.GetComponent<Text>().text = "Not enought cookies to sell";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
    }

    public void upgradeSell()
    {
      
        if (GlobalCash.CashCount >= GlobalSell.costo)
        {
            venta += 1;
            GlobalCash.CashCount -= GlobalSell.costo;
            GlobalSell.costo += 3;

        }
       
    }

  
}
