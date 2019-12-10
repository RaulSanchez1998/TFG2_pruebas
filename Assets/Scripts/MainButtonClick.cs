using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Tiene que tener el mismo nombre que el script obvio
public class MainButtonClick : MonoBehaviour
{
    //Declarar variables
    public GameObject textBox;
   
    public int sumando=1;
   // public int costo = GlobalMake.costo;
    public void ClickTheButton()
    {
         
    GlobalCookies.CookieCount += sumando;
        
    }

    public void upgradeMake()
    {
      

        if (GlobalCash.CashCount >= GlobalMake.costo )
        {
            sumando += 1;
            GlobalCash.CashCount -= GlobalMake.costo;
            GlobalMake.costo += 4;

            
        }
        
    }

    public void Update()
    {
    }




}
