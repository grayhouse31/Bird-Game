using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI scoreLavel;
    // Start is called before the first frame update
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);

        scoreLavel.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAgainPressed()
    {
        SceneManager.LoadScene("GameScene");

    }

    public void QuitPressed()
    {
        Application.Quit();
    }
}
