using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    private int kat = 1;
    public GameObject[] butonlar;
    public GameObject[] siniflar;

    public GameObject[] listeler;
    
    public GameObject _kapatButon;

    public void KatDegistir()
    {
        if(kat == 0)
        {
            butonlar[1].SetActive(false);
            butonlar[0].SetActive(true);

            siniflar[4].SetActive(false);
            siniflar[5].SetActive(false);
           for(int i = 0; i <= 3; i++){
                siniflar[i].SetActive(true);
            }
            kat = 1;
            
        }
        else if (kat == 1){
           butonlar[0].SetActive(false);
            butonlar[1].SetActive(true);

            siniflar[4].SetActive(true);
            siniflar[5].SetActive(true);

            for(int i = 0; i <= 3; i++){
                siniflar[i].SetActive(false);
            }
            kat = 0; 
            
        }
    }

    public void SekmeKapat(){
        for(int i = 0; i <= 5; i++){
            listeler[i].SetActive(false);
        }
        _kapatButon.SetActive(false);
    }
}
