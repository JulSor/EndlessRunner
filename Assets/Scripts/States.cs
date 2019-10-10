using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class States : CatMovement
{
    public GameObject gameOverPanel;
    public Text gameOverPoints;
    public TextMeshProUGUI _gameOverPoints;
    public GameObject gameOverPumpkinPic;
    public Text inGamePoints;
    public TextMeshProUGUI _inGamePoints;
    public GameObject inGamePumpkinPic;

    public Text countDown;


    // Start is called before the first frame update
    new void Start()
    {
        gameOverPanel.SetActive(false);
        anim.speed = 0;
        GameObject.Find("Cat Lite").GetComponent<CatMovement>().speed = 0;
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        countDown.text = "3";
        yield return new WaitForSeconds(1);
        countDown.text = "2";
        yield return new WaitForSeconds(1);
        countDown.text = "1";
        yield return new WaitForSeconds(1);
        countDown.text = "";
        anim.speed = 1.3f;
        GameObject.Find("Cat Lite").GetComponent<CatMovement>().speed = 12;
    }

    // Update is called once per frame
    new void Update()
    {
        
    }


    public void GameOver()
    {
        GameObject.Find("Cat Lite").GetComponent<CatMovement>().speed = 0;
        anim.speed = 0;
        gameOverPanel.SetActive(true);
        _gameOverPoints.text = _inGamePoints.text;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fence")
        {
            GameOver();
        }

    }

    public void LoadGameLevel()
    {
        SceneManager.LoadScene(0);
    }
}
