using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecoverPoint : MonoBehaviour
{
    public Slider hpslider;
    public Slider mpslider;

    private const int maxHp = 1000;
    private int currentHp;

    private const int maxMp = 800;
    private int currentMp;
    public void Start()
    {
        hpslider = GameObject.Find("StatusManager").GetComponent<StatusManager>().Hpslider;
        mpslider = GameObject.Find("StatusManager").GetComponent<StatusManager>().Mpslider;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTrggerEnter(Collider other) //全回復
    {
        if(other.gameObject.tag == "Player")
        {
            currentHp = maxHp;
            hpslider.value = currentHp;
            Debug.Log(currentHp + "Hpが回復した");

            currentMp = maxMp;
            mpslider.value = currentMp;
        }
    }
}
