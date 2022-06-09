using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TextWritten : MonoBehaviour
{
    public UIMessageText uiMessagetext;

    public GameObject playerNamePanel;
    public GameObject playPanel;
    public GameObject Player;

    public GameObject _Character0;//デフォルト
    public GameObject _Character1;//笑顔
    public GameObject _Character2;//驚き
    public GameObject _Character3;//照れる

    public GameObject _Backview;

    [SerializeField] public GameObject Button4;
    [SerializeField] public GameObject Button1;
    [SerializeField] public GameObject Button2;

    [SerializeField] public GameObject Enemy;
    [SerializeField] public GameObject Enemy1;
    [SerializeField] public GameObject Enemy2;
    [SerializeField] public GameObject Enemy3;
    [SerializeField] public GameObject Enemy4;
    [SerializeField] public GameObject Enemy5;
    [SerializeField] public GameObject Enemy6;
    [SerializeField] public GameObject Enemy7;
    [SerializeField] public GameObject Enemy8;

    public GameObject hpslider;
    public GameObject hpslider1;
    public GameObject hpslider2;
    public GameObject hpslider3;
    public GameObject hpslider4;
    public GameObject hpslider5;
    public GameObject hpslider6;
    public GameObject hpslider7;
    public GameObject hpslider8;

    public GameObject EnemeyNameText;
    public GameObject EnemeyNameText1;
    public GameObject EnemeyNameText2;
    public GameObject EnemeyNameText3;
    public GameObject EnemeyNameText4;
    public GameObject EnemeyNameText5;
    public GameObject EnemeyNameText6;
    public GameObject EnemeyNameText7;
    public GameObject EnemeyNameText8;

    public GameObject Camera;
    void Start()
    {
        GameObject.Find("StatusManager").GetComponent<StatusManager>().Hpslider.enabled = false;
        GameObject.Find("StatusManager").GetComponent<StatusManager>().Mpslider.enabled = false;

        GameObject.Find("StatusManager").GetComponent<StatusManager>()._SkillPoint.enabled = false;
        GameObject.Find("StatusManager").GetComponent<StatusManager>()._Exptext.enabled = false;
        GameObject.Find("StatusManager").GetComponent<StatusManager>()._Cointext.enabled = false;
        GameObject.Find("StatusManager").GetComponent<StatusManager>()._Enemynumber.enabled = false;

        Enemy.SetActive(false);
        Enemy1.SetActive(false);
        Enemy2.SetActive(false);
        Enemy3.SetActive(false);
        Enemy4.SetActive(false);
        Enemy5.SetActive(false);
        Enemy6.SetActive(false);
        Enemy7.SetActive(false);
        Enemy8.SetActive(false);

        hpslider.SetActive(false);
        hpslider1.SetActive(false);
        hpslider2.SetActive(false);
        hpslider3.SetActive(false);
        hpslider4.SetActive(false);
        hpslider5.SetActive(false);
        hpslider6.SetActive(false);
        hpslider7.SetActive(false);
        hpslider8.SetActive(false);

        EnemeyNameText.SetActive(false);
        EnemeyNameText1.SetActive(false);
        EnemeyNameText2.SetActive(false);
        EnemeyNameText3.SetActive(false);
        EnemeyNameText4.SetActive(false);
        EnemeyNameText5.SetActive(false);
        EnemeyNameText6.SetActive(false);
        EnemeyNameText7.SetActive(false);
        EnemeyNameText8.SetActive(false);

        GameObject.Find("StatusManager").GetComponent<StatusManager>().LvText1.enabled = false;
        _Character0.SetActive(false);
        _Character1.SetActive(false);
        _Character2.SetActive(false);
        _Character3.SetActive(false);

        playPanel.SetActive(false);
        StartCoroutine("StartSet");
        Button4.SetActive(false);
        Button1.SetActive(false);
        Button2.SetActive(false);
    }
    IEnumerator StartSet()
    {
        uiMessagetext.DrawText("あなたの名前を教えてください。");
        yield break;
    }
    public void StartGame()//ボタン
    {
        StartCoroutine("Cotext");
        GameObject.Find("UIManager").GetComponent<UIMessageText>().playerNameText.enabled = false;
        playerNamePanel.SetActive(false);
    }
    // クリック待ちのコルーチン
    IEnumerator Skip()
    {
        while (uiMessagetext.playing) yield return 0;
        while (!uiMessagetext.IsClicked()) yield return 0;
    }
    //テキストウィンドウに表示（上から下）
    IEnumerator Cotext()
    {

        Button4.SetActive(false);
        GameObject.Find("UIManager").GetComponent<UIMessageText>().inputFieldGameObject.SetActive(false);
        uiMessagetext.DrawText1("ここはどこだ？");
        yield return StartCoroutine("Skip");
        _Character0.SetActive(true);
        uiMessagetext.DrawText2("謎の声", "やっと来ましたね!");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText1("誰だ!");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "私は、惑星E385、えーと通称「地球」の管理者でーす");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText1("え？");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "貴方に分かりやすく説明すると神に近いかなー");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText1("その神様が俺にいったいなんのようですか？");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "えー、これからあなたは管理者により惑星E385から惑星D497に\n　転生してもらいまーす");
        yield return StartCoroutine("Skip");
        _Character0.SetActive(false); //デフォルト
        _Character1.SetActive(true);　//笑顔
        uiMessagetext.DrawText2("管理者", "パチパチパチ。おめでとー");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText1("え？");
        yield return StartCoroutine("Skip");
        _Character0.SetActive(true); //デフォルト
        _Character1.SetActive(false);　//笑顔
        uiMessagetext.DrawText2("管理者", "つまり転生ですねー。今、あの惑星は魔神が大陸を支配して\n　このままだと世界が崩壊してしまうのですよー。");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "ですのであなたには、管理者から依頼という形で世界のバランスを元に戻してほしいのです。");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "もちろんあなたには死なれたら困るから、私が全力で支援するから心配しないで");
        yield return StartCoroutine("Skip");
        StartCoroutine("Forking");
    }
    IEnumerator Forking() //二択の質問
    {
        Button1.SetActive(true);
        Button2.SetActive(true);
        uiMessagetext.DrawText2("管理者", "どう。依頼受けてくれる？");
        yield return StartCoroutine("Skip");
    }
    public void YES()　//はい
    {
        Button1.SetActive(false);
        Button2.SetActive(false);
        StartCoroutine("YES1");
    }
    IEnumerator YES1()　//はいを選択
    {
        uiMessagetext.DrawText1("まぁ、話を聞いたからには、受けますよ。異世界も気になりますから");
        yield return StartCoroutine("Skip");
        StartCoroutine("Cotext1");
    }
    public void NO()　//いいえ
    {
        Button1.SetActive(false);
        Button2.SetActive(false);
        StartCoroutine("NO1");
    }
    IEnumerator NO1()　//いいえを選択
    {
        uiMessagetext.DrawText1("いやです。と言いたいがあの管理者とかいう奴に逆らったらまずそうだ。\nもう一度考え直そう。");
        yield return StartCoroutine("Skip");
        StartCoroutine("Forking");
    }
    IEnumerator Cotext1()
    {
        uiMessagetext.DrawText2("管理者", "ありがとー。ここからは詳細を説明してくね");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "まず、あっちの世界はファンタジーとか言われてる世界だからそれぞれ個体値が目視できるの");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "簡単に説明すると個体値はステータスのことだよー");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "あちらの世界に転生したらステータスを確認してみて");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "後々わかると思うけど、あなたの潜在ステータスはあっちの惑星だと全てMAXなんだよ。強いですねー");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "だけど、最終的にMAXなだけで今の状態で戦闘をするのはかなり危険だよー");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "だから、あなたに私からスキルポイントのプレゼントだよー");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "スキルポイントを使ってスキルを取得すればステータスの底上げができるから頑張って");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "それでは、いってらっしゃーい");
        yield return StartCoroutine("Skip");
        _Character0.SetActive(false);
        uiMessagetext.DrawText1("いきなりだな、まぁ不安だけど、ちょっとわくわくするな");
        yield return StartCoroutine("Skip");
        StartCoroutine("GameStart");
    }
    IEnumerator GameStart() //3Dgameの始まり
    {
        playPanel.SetActive(true);
        _Backview.SetActive(false);
        Destroy(Camera);

        GameObject.Find("StatusManager").GetComponent<StatusManager>()._Player.SetActive(true);
        uiMessagetext.DrawText1("ここが異世界かー");
        yield return StartCoroutine("Skip");
        _Character0.SetActive(true); //デフォルト
        uiMessagetext.DrawText2("管理者", "すごいでしょ。");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText1("おぉー、マジですごいよ");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "そうでしょー!、私、神だから");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "そこでとりあえず目の前にいる魔物を倒すまで頑張ってー");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "この世界での体の使い方を教えるよー");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "えーと、Wキーで前進　A、Dキーで左右の視点が移動　Eキーで攻撃だよー。それじゃ");
        yield return StartCoroutine("Skip");
        _Character0.SetActive(false); //デフォルト
        uiMessagetext.DrawText1("声がきこえなくなった。まぁ、とりあえず奥に見える明らかに怪しいやつを攻撃してみるか。");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("", "敵を倒してみよう!");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("", "Wキーで前に歩くことができます。");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("", "Aキー,Dキーで左右に視点を動かすことができます。");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("", "Eキーで攻撃をすることができます。");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("", "まずは左上のボタンでスキル画面からスキルポイントを10P消費して\nスキルを取得してからゴーストに挑みましょう。\nスキルポイントは敵を倒すと手に入ります。");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("", "STRは攻撃力,VITは防御力,AGIは素早さ,HPは体力,MPは魔力を表しています");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("", "また、敵を倒すと経験値が手に入りレベルが上がります。");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("", "それでは目の前にいるゴーストを倒してみてください");
        yield return StartCoroutine("Skip");
        Enemy.SetActive(true);
        EnemeyNameText.SetActive(true);
        hpslider.SetActive(true);
        GameObject.Find("StatusManager").GetComponent<StatusManager>()._SkillPoint.enabled = true;
        GameObject.Find("StatusManager").GetComponent<StatusManager>()._Exptext.enabled = true;
        GameObject.Find("StatusManager").GetComponent<StatusManager>()._Cointext.enabled = true;
        GameObject.Find("StatusManager").GetComponent<StatusManager>()._Enemynumber.enabled = true;
        GameObject.Find("UIManager").GetComponent<UIMessageText>().talkPanel.SetActive(false);
        GameObject.Find("UIManager").GetComponent<UIMessageText>().PlayerName.enabled = true;
        GameObject.Find("StatusManager").GetComponent<StatusManager>().LvText1.enabled = true;
        GameObject.Find("StatusManager").GetComponent<StatusManager>().Hpslider.enabled = true;
        GameObject.Find("StatusManager").GetComponent<StatusManager>().Mpslider.enabled = true;

        Enemy.SetActive(true);
    }
    IEnumerator MainScene()　//チュートリアルクリア
    {
        yield return new WaitForSeconds(5f);
        GameObject.Find("UIManager").GetComponent<UIMessageText>().talkPanel.SetActive(true);
        playPanel.SetActive(false);
        _Character0.SetActive(true); //デフォルト
        EnemeyNameText.SetActive(false);
        hpslider.SetActive(false);
        uiMessagetext.DrawText2("管理者", "おつかれさまー,ありがとねー");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "まぁ、とりあえずこんな感じで魔物を倒してってほしいんだよねー");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "それじゃ、また会えるといいね。");
        yield return StartCoroutine("Skip");
        _Character0.SetActive(false); //デフォルト
        uiMessagetext.DrawText1("いよいよかー。本当にこんな世界があったんだな。");
        yield return StartCoroutine("Skip");
        yield return new WaitForSeconds(2f);
        uiMessagetext.DrawText2("", "お疲れ様でした。");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("", "これでチュートリアルは終了です。");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("", "ここからはあなたの物語です。");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("", "敵を倒しお金を稼いでアイテムを購入したりすることもできます");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("", "それでは良い異世界生活を");
        yield return StartCoroutine("Skip");
        GameObject.Find("UIManager").GetComponent<UIMessageText>().talkPanel.SetActive(false);
        GameObject.Find("StatusManager").GetComponent<StatusManager>()._Enemynumber.enabled = true;
        playPanel.SetActive(true);

        Enemy1.SetActive(true);
        Enemy2.SetActive(true);
        Enemy3.SetActive(true);
        Enemy4.SetActive(true);
        Enemy5.SetActive(true);
        Enemy6.SetActive(true);
        Enemy7.SetActive(true);
        Enemy8.SetActive(true);
    }
    IEnumerator LoseScene()
    {
        GameObject.Find("UIManager").GetComponent<UIMessageText>().talkPanel.SetActive(true);
        playPanel.SetActive(false);
        _Character0.SetActive(true); //デフォルト
        uiMessagetext.DrawText2("管理者", "負けてしまいましたね");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "もう一度やり直してもらいます。");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "次は頑張ってくださいねー");
        yield return StartCoroutine("Skip");
        SceneManager.LoadScene("TitleScene");
    }
    IEnumerator ClearScene()
    {
        GameObject.Find("UIManager").GetComponent<UIMessageText>().talkPanel.SetActive(true);
        _Backview.SetActive(true);
        playPanel.SetActive(false);
        _Character0.SetActive(true); //デフォルト
        uiMessagetext.DrawText2("管理者", "おつかれさまー。おかげでここは魔物の数が安定してきてるからもう大丈夫");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText2("管理者", "本当にありがとねー");
        yield return StartCoroutine("Skip");
        uiMessagetext.DrawText1("とりあえずは第一の依頼達成ということでいいのかな");
        yield return StartCoroutine("Skip");
        _Character1.SetActive(true); //笑顔
        uiMessagetext.DrawText2("管理者", "そうだね。依頼達成おめでとう。改めてありがとねー");
        yield return StartCoroutine("Skip");
        _Character1.SetActive(false); //笑顔
        SceneManager.LoadScene("ResultScene");
    }
}

