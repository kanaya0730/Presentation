using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControll : MonoBehaviour
{
    private enum PlayerState { STAND, RUN };

    private Animator animator;
    private PlayerState state;

    public ParticleSystem Skill;

    private const int maxHp = 1000;
    private const int minHp = 0;
    public int currentHp;

    private const int maxMp = 800;
    private const int minMp = 0;
    public int currentMp;

    public Text NameText;
    private Slider hpslider;
    private Slider mpslider;

    private int damage;
    private int VIT;
    private int AGI;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        state = PlayerState.STAND;

        hpslider = GameObject.Find("StatusManager").GetComponent<StatusManager>().Hpslider;
        mpslider = GameObject.Find("StatusManager").GetComponent<StatusManager>().Mpslider;

        hpslider.maxValue = maxHp;
        currentHp = maxHp;
        hpslider.value = currentHp;

        mpslider.maxValue = maxMp;
        currentMp = maxMp;
        mpslider.value = currentMp;
    }

    // Update is called once per frame
    void Update()
    {
        VIT = StatusManager.GetVITScore();
        AGI = StatusManager.GetAGIScore(); 
        if(currentHp >= GameObject.Find("StatusManager").GetComponent<StatusManager>().maxHp)
        {
            currentHp = GameObject.Find("StatusManager").GetComponent<StatusManager>().maxHp;
        }
        if(damage <= 0)
        {
            damage = 0;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * AGI;

            if (state == PlayerState.STAND)
            {
                state = PlayerState.RUN;
                animator.SetBool("Run", true);
            }
        }
        else
        {
            if (state == PlayerState.RUN)
            {
                state = PlayerState.STAND;
                animator.SetBool("Run", false);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -5, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 5, 0);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("Attack");    //Eキーで攻撃モーション
        }
        if(Input.GetKeyDown(KeyCode.Q) && currentMp >= 100) 
        {
            Skill.Play();
            currentMp -= 100;
            Debug.Log(currentMp + "消費");
            mpslider.value = currentMp; // Sliderに現在MPを適用

        }
        if(hpslider.value <= 0)
        {
            currentHp = 0;
            animator.SetBool("Death", true);
            GameObject.Find("UIManager").GetComponent<TextWritten>().StartCoroutine("LoseScene");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            damage = Random.Range(20, 70);
            Debug.Log(damage + "損傷");
            damage -= VIT;
            currentHp -= damage;
            Debug.Log(damage + "ダメージ");
            hpslider.value = currentHp;   // Sliderに現在HPを適用
            Debug.Log("残りHPゲージ" + hpslider.value);
        }
    }
}
   
