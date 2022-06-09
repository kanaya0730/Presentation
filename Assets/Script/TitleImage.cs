using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleImage : MonoBehaviour
{
    public GameObject Image;//普通
    public GameObject Image1;//笑顔
    public GameObject Image2;//泣き
    public GameObject Image3;//ショック
    public GameObject Image4;//怒る
    public GameObject Image5;//照れる
    public void Start()
    {
        Image1.SetActive(false);
        Image2.SetActive(false);
        Image3.SetActive(false);
        Image4.SetActive(false);
        Image5.SetActive(false);
        Invoke("Egao",2f);
    }
    public void Egao()
    {
        Image1.SetActive(true);
        Invoke("Naki", 2f);
    }
    public void Naki()
    {
        Image2.SetActive(true);
        Invoke("Shock", 2f);
    }
    public void Shock()
    {
        Image3.SetActive(true);
        Invoke("Okoru", 2f);
    }
    public void Okoru()
    {
        Image4.SetActive(true);
        Invoke("Tereru", 2f);
    }
    public void Tereru()
    {
        Image5.SetActive(true);
        Invoke("Start", 2f);
    }
}
