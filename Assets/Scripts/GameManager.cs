using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    private int score ;
    private void Awake()
    {
        Application.targetFrameRate=60;
        Pause();
    }
    public void Play()
    {
       score=0;
       
       scoreText.text=score.ToString();
       playButton.SetActive(false);
       gameOver.SetActive(false);
       Time.timeScale=1f;
       player.enabled=true;
       Pipes[] pipes=FindObjectsOfType<Pipes>();
       for(int i=0;i<pipes.Length;i++)
       {
        Destroy(pipes[i].gameObject);
       }
    }
     
    public void Pause()
    {
        Time.timeScale=0f;
        player.enabled=false;
        
        
    }
   

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        
       
        
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text=score.ToString();
    }
}
