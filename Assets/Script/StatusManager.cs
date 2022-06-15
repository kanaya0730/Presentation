using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatusManager : MonoBehaviour
{
	/// <summary>MAX体力</summary>
	[Header("MAX体力")]
	public int maxHp = 1000;
	/// <summary>MAX魔力</summary>
	[Header("MAX魔力")] 
	public int maxMp = 800;
	const int maxExp = 1000;
	const int minHp = 0;
	const int minMp = 0;
	const int minExp = 0;
	/// <summary>現在のお金</summary>
	[SerializeField]
	[Header("お金")]int coin = 100;
	/// <summary>現在のHP</summary>
	[SerializeField] 
	[Header("体力")]static int currentHP;
	/// <summary>現在のMP</summary>
	[SerializeField]
	[Header("魔力")]static int currentMP;
	/// <summary>現在の攻撃力</summary>
	[SerializeField]
	[Header("攻撃力")]static int STR = 10;
	/// <summary>現在の防御力</summary>
	[SerializeField]
	[Header("防御力")] static int VIT = 10;
	/// <summary>現在の素早さ</summary>
	[SerializeField]
	[Header("素早さ")]static int AGI = 10;
	[SerializeField] int currentExp;
	public Slider Hpslider;
	public Slider Mpslider;
	public Slider Expslider;
    public Text HpText;
	public Text MpText;
	public Text StrText;
	public Text DefText;
	public Text VitText;
	public Text AgiText;
	public Text countText;
	public Text ErrorText;

	public Text LvText;
	public Text LvText1;
	public Text ExpText;
	public Text CoinText;

	public Text _Text;
	public Text _Text1;
	public Text _Text2;
	public Text _Text3;
	public Text _Text4;
	public Text _Text5;
	public Text _Text6;
	public Text _Text7;
	public Text _Text8;
	public Text _Text9;
	public Text _Text10;
	public Text _Text11;
	public Text _Text12;
	public Text _Text13;
	public Text _Text14;
	public Text _Text15;
	public Text _Text16;
	public Text _Text17;
	public Text _Text18;
	public Text _Text19;
	public Text _Text20;
	public Text _Text21;
	public Text _Text22;
	public Text _Text23;
	public Text _Text24;
	public Text _Text25;
	public Text _Text26;
	public Text _Text27;
	public Text _Text28;
	public Text _Text29;
	public Text _Text30;
	public Text _Text31;
	public Text _Text32;
	public Text _Text33;
	public Text _Text34;
	public Text _Text35;
	public Text _Text36;
	public Text _Text37;
	public Text _Text38;

	public Text _Enemynumber;
	public Text _SkillPoint;
	public Text _Cointext;
	public Text _Exptext;


	private bool button;
	private bool button1;
	private bool button2;
	private bool button3;
	private bool button4;
	public bool button5;
	private bool button6;
	private bool button7;
	private bool button8;
	private bool button9;
	private bool button10;
	public bool button11;
	private bool button12;
	private bool button13;
	private bool button14;
	private bool button15;
	private bool button16;
	public bool button17;
	private bool button18;
	private bool button19;
	private bool button20;
	private bool button21;
	private bool button22;
	public bool button23;
	private bool button24;
	private bool button25;
	private bool button26;
	private bool button27;
	private bool button28;
	public bool button29;
	private bool button30;
	private bool button31;
	private bool button32;
	private bool button33;
	private bool button34;
	public bool button35;
	private bool button36;
	private bool button37;
	private bool button38;
	private bool button39;
	private bool button40;
	public bool button41;
	private bool button42;
	private bool button43;
	private bool button44;
	private bool button45;
	private bool button46;
	public bool button47;

	private bool Potion;
	private bool HighPotion;
	private bool FullPotion;

	public GameObject _Player;

	public GameObject _SkillPanel;
	public GameObject _degreePanel;
	public GameObject _StatusPanel;
	public GameObject _ShopPanel;
	[SerializeField] private int clickCount = 0;
	[SerializeField] private static int Exp = 0;
	private int Lv = 1;
	private int Enemynumber = 8;



    // Use this for initialization
    void Start()
	{
		button = false;
		button1 = false;
		button2 = false;
		button3 = false;
		button4 = false;
		button5 = false;
		button6 = false;
		button7 = false;
		button8 = false;
		button9 = false;
		button10 = false;
		button11 = false;
		button12 = false;
		button13 = false;
		button14 = false;
		button15 = false;
		button16 = false;
		button17 = false;
		button18 = false;
		button19 = false;
		button20 = false;
		button21 = false;
		button22 = false;
		button23 = false;
		button24 = false;
		button25 = false;
		button26 = false;
		button28 = false;
		button29 = false;
		button30 = false;
		button31 = false;
		button32 = false;
		button33 = false;
		button34 = false;
		button35 = false;
		button36 = false;

		Potion = false;
		HighPotion = false;
		FullPotion = false;

		_degreePanel.SetActive(false);
		_StatusPanel.SetActive(false);
		_SkillPanel.SetActive(false);

		_Player.SetActive(false);

		Hpslider.maxValue = maxHp;
		currentHP = maxHp;
		Hpslider.value = currentHP;

		Mpslider.maxValue = maxMp;
		currentMP = maxMp;
		Mpslider.value = currentMP;

		Expslider.maxValue = maxExp;
		currentExp = minExp;
		Expslider.value = currentExp;
	}
	public void EXP()
	{
		currentExp += 500;
		Exp += 500;
		Debug.Log("現在のEXPは" + currentExp);
	}
	public void SkillPoint()
    {
		clickCount += 5;
		Debug.Log("現在のスキルポイントは" + clickCount + "P");
	}
	public void Coin()
    {
		coin += 30;
		Debug.Log("現在の金額は" + coin + "G");
    }
	public void EnemyDeath()
    {
		Enemynumber -= 1;
		Debug.Log("残りの敵" + Enemynumber);
    }
	public void Update()
	{
		//_texts[0].text = "";

		if (maxHp >= 9999)
		{
			maxHp = 1000;
		}
		if (maxMp >= 9999)
		{
			maxMp = 9999;
		}
		if (STR >= 9999)
		{
			STR = 9999;
		}
		if (VIT >= 9999)
		{
			VIT = 9999;
		}
		if (AGI >= 9999)
		{
			AGI = 9999;
		}
		if(currentExp >= 1000)
        {
			currentExp = 1000;
		}
		if(Enemynumber <= 0)
        {
			StartCoroutine("ClearScene");
        }
		HpText.text = maxHp.ToString();
		MpText.text = maxMp.ToString();
		StrText.text = STR.ToString();
		VitText.text = VIT.ToString();
		AgiText.text = AGI.ToString();
		countText.text = clickCount.ToString();

		LvText.text = Lv.ToString();
		LvText1.text = "Lv." + Lv.ToString();
		ExpText.text = Exp.ToString();
		CoinText.text = coin.ToString() + " G";
		_Cointext.text = "現在の所持金: " + coin.ToString() + " G";
		_Exptext.text = "現在の獲得経験値: " + Exp.ToString();
		_SkillPoint.text = "現在の所持スキルポイント: " + clickCount.ToString() + " P";

		_Enemynumber.text = "残り" + Enemynumber.ToString() + "/8体";

		Hpslider.maxValue = maxHp;
		Mpslider.maxValue = maxMp;

		Expslider.value = currentExp;

		if (Exp >= 0 && Exp < 999)
        {
			Lv = 1;
        }
		if (Exp >= 1000 && Exp < 1999 && Lv == 1)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 2;
		}
		if (Exp >= 2000 && Exp < 2999 && Lv == 2)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 3;
		}
		if (Exp >= 3000 && Exp < 3999 && Lv == 3)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 4;
		}
		if (Exp >= 4000 && Exp < 4999 && Lv == 4)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 5;
		}
		if (Exp >= 5000 && Exp < 5999 && Lv == 5)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 6;
		}
		if (Exp >= 6000 && Exp < 6999 && Lv == 6)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 7;
		}
		if (Exp >= 7000 && Exp < 7999 && Lv == 7)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 8;
		}
		if (Exp >= 8000 && Exp < 8999 && Lv == 8)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 40;
			VIT += 40;
			AGI += 40;
			currentExp = 0;
			Lv = 9;
		}
		if (Exp >= 9000 && Exp < 9999 && Lv == 9) //Lv.10
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 10;
		}
		if (Exp >= 10000 && Exp < 10999 && Lv == 10)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 11;
		}
		if (Exp >= 11000 && Exp < 11999 && Lv == 11)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 12;
		}
		if (Exp >= 12000 && Exp < 12999 && Lv == 12)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 13;
		}
		if (Exp >= 13000 && Exp < 13999 && Lv == 13)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 14;
		}
		if (Exp >= 14000 && Exp < 14999 && Lv == 14)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 15;
		}
		if (Exp >= 15000 && Exp < 15999 && Lv == 15)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 16;
		}
		if (Exp >= 16000 && Exp < 16999 && Lv == 16)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 17;
		}
		if (Exp >= 17000 && Exp < 17999 && Lv == 17)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 18;
		}
		if (Exp >= 18000 && Exp < 18999 && Lv == 18)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 19;
		}
		if (Exp >= 19000 && Exp < 19999 && Lv == 19) //Lv.20
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 20;
		}
		if (Exp >= 20000 && Exp < 20999 && Lv == 20)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 21;
		}
		if (Exp >= 21000 && Exp < 21999 && Lv == 21)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 22;
		}
		if (Exp >= 22000 && Exp < 22999 && Lv == 22)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 23;
		}
		if (Exp >= 23000 && Exp < 23999 && Lv == 23)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 24;
		}
		if (Exp >= 24000 && Exp < 24999 && Lv == 24)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 25;
		}
		if (Exp >= 25000 && Exp < 25999 && Lv == 25)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 26;
		}
		if (Exp >= 26000 && Exp < 26999 && Lv == 26)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 27;
		}
		if (Exp >= 27000 && Exp < 27999 && Lv == 27)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 28;
		}
		if (Exp >= 28000 && Exp < 28999 && Lv == 28)
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 29;
		}
		if (Exp >= 29000 && Exp < 29999 && Lv == 29) //Lv.30
		{
			maxHp += 10;
			maxMp += 10;

			STR += 10;
			VIT += 10;
			AGI += 10;
			currentExp = 0;
			Lv = 30;
		}
		if (clickCount <= 0)
        {
			clickCount = 0;
		}
	}
	public void Status() //ステータス画面の表示
    {
		_StatusPanel.SetActive(true);
    }
	public void CloseStatus() //ステータス画面の非表示
	{
		_StatusPanel.SetActive(false);
	}
	public void Skill() //スキル画面の表示
	{
		_SkillPanel.SetActive(true);
	}
	public void CloseSkill() //スキル画面の非表示
	{
		_SkillPanel.SetActive(false);
	}
	public void degree() //称号画面の表示
	{
		_degreePanel.SetActive(true);
    }
	public void Closedegree() //称号画面の非表示
	{
		_degreePanel.SetActive(false);
	}
	public void Shop() //アイテム売店画面の表示
	{
		_ShopPanel.SetActive(true);
	}
	public void CloseShop() //売店画面の非表示
	{
		_ShopPanel.SetActive(false);
	}
	public void LoadTilte()
    {
		SceneManager.LoadScene("TitleScene");
    }
	public static int GetSTRScore()
	{
		return STR;
	}
	public static int GetVITScore()
	{
		return VIT;
	}
	public static int GetAGIScore()
	{
		return AGI;
	}
	public void Swordskill1() //剣術
    {
		if (STR < 9999 && clickCount >= 10 && button == false)
        {
			button = true;
			_Text.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			STR += 10;
			
			Debug.Log("現在のSTRは" + STR);
		}
		if (STR == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
    }
	public void Swordskill2() //剣術 Lv.2
	{
		if (STR < 9999 && clickCount >= 10 && button1 == false && button == true)
		{
			button1 = true;
			_Text1.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			STR += 20;
			Debug.Log("現在のSTRは" + STR);
		}
		if(STR == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Swordskill3() //剣術 Lv.3
	{
		if (STR < 9999 && clickCount >= 10 && button2 == false && button1 == true)
		{
			button2 = true;
			_Text2.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			STR += 30;
			//Strslider.value = STR;
			Debug.Log("現在のSTRは" + STR);
		}
		if (STR == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Swordskill4() //剣術 Lv.4
	{
		if (STR < 9999 && clickCount >= 10 && button3 == false && button2 == true)
		{
			button3 = true;
			_Text3.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			STR += 40;
			Debug.Log("現在のSTRは" + STR);
		}
		if (STR == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Swordskill5() //剣術 Lv.5
	{
		if (STR < 9999 && clickCount >= 10 && button4 == false && button3 == true)
		{
			button4 = true;
			_Text4.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			STR += 50;
			//Vitslider.value = VIT;
			Debug.Log("現在のSTRは" + STR);
		}
		if (STR == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Swordskill6() //剣術 Lv.6
	{
		if (STR < 9999 && clickCount >= 10 && button5 == false && button4 == true)
		{
			button5 = true;
			_Text5.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			STR += 60;
			//Agislider.value = AGI;
			Debug.Log("現在のSTRは" + STR);
		}
		if (STR == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Magicup1() //魔力増幅Lv.1
	{
		if (currentMP < 9999 && clickCount >= 10 && button6 == false)
		{
			button6 = true;
			_Text6.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			maxMp += 10;
			Mpslider.value = currentMP;
			Debug.Log("現在のMPは" + currentMP);
		}
		if (currentMP == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Magicup2() //魔力増幅Lv.2
	{
		if (currentMP < 9999 && clickCount >= 10 && button7 == false && button6 == true)
		{
			button7 = true;
			_Text7.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			maxMp += 20;
			Mpslider.value = currentMP;
			Debug.Log("現在のMPは" + currentMP);
		}
		if (currentMP == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Magicup3() //魔力増幅Lv.3
	{
		if (currentMP < 9999 && clickCount >= 10 && button8 == false && button7 == true)
		{
			button8 = true;
			_Text8.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			maxMp += 30;
			Mpslider.value = currentMP;
			Debug.Log("現在のMPは" + currentMP);
		}
		if (currentMP == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Magicup4() //魔力増幅Lv.4
	{
		if (currentMP < 9999 && clickCount >= 10 && button9 == false && button8 == true)
		{
			button9 = true;
			_Text9.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			maxMp += 40;
			Mpslider.value = currentMP;
			Debug.Log("現在のMPは" + currentMP);
		}
		if (currentMP == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Magicup5() //魔力増幅Lv.5
	{
		if (currentMP < 9999 && clickCount >= 10 && button10 == false && button9 == true)
		{
			button10 = true;
			_Text10.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			maxMp += 50;
			Mpslider.value = currentMP;
			Debug.Log("現在のMPは" + currentMP);
		}
		if (currentMP == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Magicup6() //魔力増幅Lv.6
	{
		if (currentMP < 9999 && clickCount >= 10 && button11 == false && button10 == true)
		{
			button11 = true;
			_Text11.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			maxMp += 60;
			Mpslider.value = currentMP;
			Debug.Log("現在のMPは" + currentMP);
		}
		if (currentMP == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Defense1() //防御 Lv.1
	{
		if (VIT < 9999 && clickCount >= 10 && button12 == false)
		{
			button12 = true;
			_Text12.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			VIT += 10;
			Debug.Log("現在のVITは" + VIT);
		}
		if (VIT == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Defense2() //防御 Lv.2
	{
		if (VIT < 9999 && clickCount >= 10 && button13 == false && button12 == true)
		{
			button13 = true;
			_Text13.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			VIT += 20;
			Debug.Log("現在のVITは" + VIT);
		}
		if (VIT == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Defense3() //防御 Lv.3
	{
		if (VIT < 9999 && clickCount >= 10 && button14 == false && button13 == true)
		{
			button14 = true;
			_Text14.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			VIT += 30;
			Debug.Log("現在のVITは" + VIT);
		}
		if (VIT == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Defense4() //防御 Lv.4
	{
		if (VIT < 9999 && clickCount >= 10 && button15 == false && button14 == true)
		{
			button15 = true;
			_Text15.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			VIT += 40;
			Debug.Log("現在のVITは" + VIT);
		}
		if (VIT == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Defense5() //防御 Lv.5
	{
		if (VIT < 9999 && clickCount >= 10 && button16 == false && button15 == true)
		{
			button16 = true;
			_Text16.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			VIT += 50;
			Debug.Log("現在のVITは" + VIT);
		}
		if (VIT == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Defense6() //　防御 Lv.6
	{
		if (VIT < 9999 && clickCount >= 10 && button17 == false && button16 == true)
		{
			button17 = true;
			_Text17.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			VIT += 60;
			Debug.Log("現在のVITは" + VIT);
		}
		if (VIT == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Speedup1() //　脚力強化 Lv.1
	{
		if (AGI < 9999 && clickCount >= 10 && button18 == false)
		{
			button18 = true;
			_Text18.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			AGI += 10;
			Debug.Log("現在のAGIは" + AGI);
		}
		if (currentMP == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Speedup2() //　脚力強化 Lv.2
	{
		if (AGI < 9999 && clickCount >= 10 && button19 == false && button18 == true)
		{
			button19 = true;
			_Text19.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			AGI += 20;
			Debug.Log("現在のAGIは" + AGI);
		}
		if (AGI == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Speedup3() //　脚力強化 Lv.3
	{
		if (AGI < 9999 && clickCount >= 10 && button20 == false && button19 == true)
		{
			button20 = true;
			_Text20.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			AGI += 30;
			Debug.Log("現在のAGIは" + AGI);
		}
		if (AGI == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Speedup4() //　脚力強化 Lv.4
	{
		if (currentMP < 9999 && clickCount >= 10 && button21 == false && button20 == true)
		{
			button21 = true;
			_Text21.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			AGI += 40;
			Debug.Log("現在のAGIは" + AGI);
		}
		if (AGI == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Speedup5() //　脚力強化 Lv.5
	{
		if (AGI < 9999 && clickCount >= 10 && button22 == false && button21 == true)
		{
			button22 = true;
			_Text22.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			AGI += 50;
			Debug.Log("現在のAGIは" + AGI);
		}
		if (AGI == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Speedup6() //　脚力強化 Lv.6
	{
		if (AGI < 9999 && clickCount >= 10 && button23 == false && button22 == true)
		{
			button23 = true;
			_Text23.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			AGI += 60;
			Debug.Log("現在のAGIは" + AGI);
		}
		if (AGI == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Hprecovery1() //　自然治癒 Lv.1
	{
		if (currentHP < 9999 && clickCount >= 10 && button24 == false)
		{
			button24 = true;
			_Text24.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			maxHp += 10;
			Hpslider.value = maxHp;
			Debug.Log("現在のHPは" + currentHP);
		}
		if (currentHP == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Hprecovery2() //　自然治癒 Lv.2
	{
		if (currentHP < 9999 && clickCount >= 10 && button25 == false && button24 == true)
		{
			button25 = true;
			_Text25.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			maxHp += 20;
			Hpslider.value = maxHp;
			Debug.Log("現在のHPは" + currentHP);
		}
		if (currentHP == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Hprecovery3() //　自然治癒 Lv.3
	{
		if (currentHP < 9999 && clickCount >= 10 && button26 == false && button25 == true)
		{
			button26 = true;
			_Text26.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			maxHp += 30;
			Hpslider.value = maxHp;
			Debug.Log("現在のHPは" + currentHP);
		}
		if (currentHP == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Hprecovery4() //　自然治癒 Lv.4
	{
		if (currentHP < 9999 && clickCount >= 10 && button27 == false && button26 == true)
		{
			button27 = true;
			_Text27.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			maxHp += 40;
			currentHP = maxHp;
			Hpslider.value = maxHp;
			Debug.Log("現在のHPは" + currentHP);
		}
		if (currentHP == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Hprecovery5() //　自然治癒 Lv.5
	{
		if (currentHP < 9999 && clickCount >= 10 && button28 == false && button27 == true)
		{
			button28 = true;
			_Text28.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			maxHp += 50;
			currentHP = maxHp;
			Hpslider.value = maxHp;
			Debug.Log("現在のHPは" + currentHP);
		}
		if (currentHP == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void Hprecovery6() //　自然治癒 Lv.6
	{
		if (AGI < 9999 && clickCount >= 10 && button29 == false && button28 == true)
		{
			button29 = true;
			_Text29.color = new Color(255, 255, 255, 255);
			clickCount -= 10;
			maxHp += 60;
			currentHP = maxHp;
			Hpslider.value = maxHp;
			Debug.Log("現在のHPは" + currentHP);
		}
		if (currentHP == 9999)
		{
			Debug.Log("これ以上強化できません");
			ErrorText.text = "これ以上強化できません";
		}
	}
	public void ItemPotion()
    {
		if(coin >= 50 && Potion == false)
        {
			Potion = true;
			coin -= 50;
		}
	}
	public void ItemHighPotion()
    {
		if (coin >= 80 && HighPotion == false)
		{
			HighPotion = true;
			coin -= 80;
		}
	}
	public void ItemFullPotion()
    {
		if (coin >= 150 && FullPotion == false)
		{
			FullPotion = true;
			coin -= 150;
		}
	}
	public void UseItemPotion()　//200回復
	{
		if (Potion == true)
		{
			Potion = false;
			GameObject.Find("SwordWarrior").GetComponent<PlayerControll>().currentHp += 200;
			Hpslider.value = GameObject.Find("SwordWarrior").GetComponent<PlayerControll>().currentHp;
			Debug.Log("HPを200回復");
			Debug.Log("現在のHPは" + GameObject.Find("SwordWarrior").GetComponent<PlayerControll>().currentHp);
		}
	}
	public void UseItemHighPotion()　//500回復
	{
		if (HighPotion == true)
		{
			HighPotion = false;
			GameObject.Find("SwordWarrior").GetComponent<PlayerControll>().currentHp += 500;
			Hpslider.value = GameObject.Find("SwordWarrior").GetComponent<PlayerControll>().currentHp;
			Debug.Log("HPを500回復");
			Debug.Log("現在のHPは" + GameObject.Find("SwordWarrior").GetComponent<PlayerControll>().currentHp);
		}
	}
	public void UseItemFullPotion()　//全回復
	{
		if (FullPotion == true)
		{
			FullPotion = false;
			GameObject.Find("SwordWarrior").GetComponent<PlayerControll>().currentHp += 1000;
			Hpslider.value = GameObject.Find("SwordWarrior").GetComponent<PlayerControll>().currentHp;
			Debug.Log("HPを1000回復");
			Debug.Log("現在のHPは" + GameObject.Find("SwordWarrior").GetComponent<PlayerControll>().currentHp);
		}
	}
}