using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public GameObject[] menu;

    public GameObject _kapatButon;


   public void ButonTikla()
   {
    _kapatButon.SetActive(true);
    Debug.Log(gameObject.name);
    menu[0].SetActive(true);
    menu[1].SetActive(false);
    menu[2].SetActive(false);
    menu[3].SetActive(false);
    menu[4].SetActive(false);
    menu[5].SetActive(false);
    
   }
}
