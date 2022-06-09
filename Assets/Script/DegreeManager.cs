using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DegreeManager : MonoBehaviour
{
	public Text _Text; //勇者
	public Text _Text1; //魔王
	public Text _Text2; //賢者
	public Text _Text3; //剣聖
	public Text _Text4; //英雄
	public Text _Text5; //騎士
	public Text _Text6; //幽霊殺し
	public Text _Text7; //魔導士
	public Text _Text8; //剣帝
	public Text _Text9; //強欲
	public Text _Text10; //色欲
	public Text _Text11; //怠惰
	public Text _Text12; //竜殺し
	public Text _Text13; //神殺し
	public Text _Text14; //聖霊殺し
	public Text _Text15; //国王
	public Text _Text16; //魔帝
	public Text _Text17; //魔導騎士
	public Text _Text18; //帝王
	public Text _Text19; //傲慢
	public Text _Text20; //嫉妬
	public Text _Text21; //暴食
	public Text _Text22; //天帝
	public Text _Text23; //女神
	public Text _Text24; //狂人
	public Text _Text25; //村人
	public Text _Text26; //大罪
	public Text _Text27; //竜王
	public Text _Text28; //不死
	public Text _Text29; //神速
	public Text _Text30; //
	public Text _Text31; //
	public Text _Text32; //
	public Text _Text33; //
	public Text _Text34; //
	public Text _Text35; //
	public Text _Text36; //

	private int STR;
	private int VIT;

	public Text Degreetext;
    void Update()
    {
		STR = StatusManager.GetSTRScore();
		VIT = StatusManager.GetVITScore();

		if (GameObject.Find("StatusManager").GetComponent<StatusManager>().button5 == true) //剣聖
        {
			_Text3.color = new Color(255, 255, 255, 255);
			STR += 80;
			Degreetext.text = "称号「剣聖」を取得しました";
		}
		if (GameObject.Find("StatusManager").GetComponent<StatusManager>().button11 == true) //賢者
		{
			_Text2.color = new Color(255, 255, 255, 255);
			Degreetext.text = "称号「賢者」を取得しました";
		}
		if (GameObject.Find("StatusManager").GetComponent<StatusManager>().button17 == true) //騎士
		{
			_Text5.color = new Color(255, 255, 255, 255);
			VIT += 80;
			Degreetext.text = "称号「騎士」を取得しました";
		}
		if (GameObject.Find("StatusManager").GetComponent<StatusManager>().button23 == true)　//神速
		{
			_Text29.color = new Color(255, 255, 255, 255);
			Degreetext.text = "称号「神速」を取得しました";
		}
		if (GameObject.Find("StatusManager").GetComponent<StatusManager>().button29 == true)　//不死
        {
			_Text28.color = new Color(255, 255, 255, 255);
			Degreetext.text = "称号「不死」を取得しました";
		}
	}
}
