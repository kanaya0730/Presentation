
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIMessageText : MonoBehaviour
{
    // nameText:喋っている人の名前
    // talkText:喋っている内容やナレーション
    public Text nameText;
    public Text MainText;

    public GameObject talkPanel;

    public bool playing = false;
    public float textSpeed = 0.1f;
    [SerializeField] public GameObject inputFieldGameObject;
    [SerializeField] public InputField inputField;

    [SerializeField] public GameObject Button;

    public string player;
    public Text playerText;
    public Text playerNameText;
    public Text PlayerName;
    public void Start()
    {
        talkPanel.SetActive(true);
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
        inputFieldGameObject.SetActive(true);
    }
    public void Update()
    {
        playerText.text = player;
        playerNameText.text = player;
        PlayerName.text = player;
    }
    // クリックで次のページを表示させるための関数
    public bool IsClicked()
    {
        if(Input.GetMouseButtonDown(0)) return true;
        return false;
    }

    // ナレーション用のテキストを生成する関数
    public void DrawText(string text)
    {
        nameText.text = "";
        StartCoroutine("CoDrawText", text);
    }
    // 通常会話用のテキストを生成する関数
    public void DrawText1(string text)
    {
        nameText.text = player;
        StartCoroutine("CoDrawText", "「" + text + "」");
    }
    public void DrawText2(string name, string text)
    {
        nameText.text = name;
        StartCoroutine("CoDrawText", "「" + text + "」");
    }
    // テキストが一文字ずつ出てくるためのコルーチン
    IEnumerator CoDrawText(string text)
    {
        playing = true;
        float time = 0;
        while (true)
        {
            yield return 0;
            time += Time.deltaTime;

            // ボタンを押されると一気に表示
            if (IsClicked()) break;

            int len = Mathf.FloorToInt(time / textSpeed);
            if (len > text.Length) break;
            MainText.text = text.Substring(0, len);
        }
        MainText.text = text;
        yield return 0;
        playing = false;
    }
    public void GetInputplayerName()
    {
        //InputFieldからテキスト情報を取得する
        player = inputField.text;
        Debug.Log(player);
        //入力フォームのテキストを空にする
        inputField.text = "";
        Button.SetActive(true);
    }
}