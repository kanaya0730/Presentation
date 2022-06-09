using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class Title : MonoBehaviour
{
    public GameObject creditImage;
    // Start is called before the first frame update
    void Start()
    {
        creditImage.SetActive(false);
    }
    public void CreditImage()
    {
        creditImage.SetActive(true);
    }
    public void CloseCreditImage()
    {
        creditImage.SetActive(false);
    }
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Replay()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
