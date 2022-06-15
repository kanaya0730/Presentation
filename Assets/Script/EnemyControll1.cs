using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyControll1 : MonoBehaviour
{
	private bool hasAniComp = false;

	private bool EnemyDeth = false;
	private const int maxHp = 500;
	private const int minHp = 0;
	private int currentHp;

	public Text NameText;
	public Slider hpslider;

	private int STR;
	private int VIT;
	void Start()
	{
		if (null != GetComponent<Animation>())
		{
			hasAniComp = true;
		}

		hpslider.maxValue = maxHp;
		currentHp = maxHp;
		hpslider.value = currentHp;

	}
	bool CheckAniClip(string clipname)
	{
		if (this.GetComponent<Animation>().GetClip(clipname) == null)
			return false;
		else if (this.GetComponent<Animation>().GetClip(clipname) != null)
			return true;

		return false;
	}
	// Update is called once per frame
	void Update()
	{
		STR = StatusManager.GetSTRScore();
		VIT = StatusManager.GetVITScore();
		/*if (hasAniComp == true)
		{
			if (Input.GetKey(KeyCode.V))
			{
				if (CheckAniClip("dead") == false) return;

				GetComponent<Animation>().CrossFade("dead", 0.2f);
				//					animation.CrossFadeQueued("idle_normal");
			}



			if (Input.GetKey(KeyCode.Q))
			{
				if (CheckAniClip("attack_short_001") == false) return;

				GetComponent<Animation>().CrossFade("attack_short_001", 0.0f);
				GetComponent<Animation>().CrossFadeQueued("idle_combat");
			}



			if (Input.GetKey(KeyCode.Z))
			{
				if (CheckAniClip("damage_001") == false) return;

				GetComponent<Animation>().CrossFade("damage_001", 0.0f);
				GetComponent<Animation>().CrossFadeQueued("idle_combat");
			}



			if (Input.GetKey(KeyCode.D))
			{
				if (CheckAniClip("idle_normal") == false) return;

				GetComponent<Animation>().CrossFade("idle_normal", 0.0f);
				GetComponent<Animation>().CrossFadeQueued("idle_normal");
			}

			if (Input.GetKey(KeyCode.F))
			{
				if (CheckAniClip("idle_combat") == false) return;

				GetComponent<Animation>().CrossFade("idle_combat", 0.0f);
				GetComponent<Animation>().CrossFadeQueued("idle_normal");
			}
		}*/
		if (currentHp <= 0 && EnemyDeth == false)
		{
			EnemyDeth = true;
			if (CheckAniClip("dead") == false) return;

			GameObject.Find("StatusManager").GetComponent<StatusManager>().EXP();
			GameObject.Find("StatusManager").GetComponent<StatusManager>().SkillPoint();
			GameObject.Find("StatusManager").GetComponent<StatusManager>().Coin();
			GameObject.Find("StatusManager").GetComponent<StatusManager>().EnemyDeath();
			GetComponent<Animation>().CrossFade("dead", 0.2f);
			GameObject.Find("UIManager").GetComponent<TextWritten>().hpslider1.SetActive(false);
			GameObject.Find("UIManager").GetComponent<TextWritten>().EnemeyNameText1.SetActive(false);
			Destroy(gameObject, 4.5f);
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player" && currentHp >= 1)
		{

			if (CheckAniClip("idle_combat") == false) return;

			GetComponent<Animation>().CrossFade("idle_combat", 0.0f);
			GetComponent<Animation>().CrossFadeQueued("idle_normal");

		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PlayerSword")
		{
			currentHp -= STR;       // 現在のHPを減らす
			Debug.Log(STR + "ダメージ");
			hpslider.value = currentHp;   // Sliderに現在HPを適用
			Debug.Log("slider.value = " + hpslider.value);

			if (CheckAniClip("damage_00rrentHp -= 1") == false) return;

			GetComponent<Animation>().CrossFade("damage_001", 0.0f);
			GetComponent<Animation>().CrossFadeQueued("idle_combat");
		}
	}
	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player" && currentHp >= 1)
		{
			GameObject.Find("UIManager").GetComponent<TextWritten>().hpslider1.SetActive(true);
			GameObject.Find("UIManager").GetComponent<TextWritten>().EnemeyNameText1.SetActive(true);

			if (CheckAniClip("attack_short_001") == false) return;

			GetComponent<Animation>().CrossFade("attack_short_001", 0.0f);
			GetComponent<Animation>().CrossFadeQueued("idle_combat");

		}

	}
}
