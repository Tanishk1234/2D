using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.ParticleSystemJobs;

public class GM1 : MonoBehaviour
{
    private VM1 VM1;
    private AudioManager AM;
    public GameObject AudMag;
    public GameObject VidMag;
    public GameObject StartPanel;
    public GameObject PauseMenu;
    public GameObject WinMenu;
    public GameObject PauseButton;
    public GameObject GameOverMenu;
    public Text CountDownText;
    private float CurrentTime;
    public float StartingTime;
    private int CurrentIndex;
     void Awake()
    {
        VM1 = VidMag.GetComponent<VM1>();
        AM  = AudMag.GetComponent<AudioManager>();
    }
    void Start()
    {
        CurrentIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        CurrentTime = StartingTime;
        PauseMenu                .SetActive(false);
        PauseButton              .SetActive(true);
        WinMenu                  .SetActive(false);
        VM1.WinVideoPanel        .SetActive(false);
        VM1.GameOverVideoPanel   .SetActive(false);
        VM1.PauseVideoPanel      .SetActive(false);
        VM1.StartVideoPanel      .SetActive(true);
        AM.StratAudio            .Play();
        VM1.PauseVideo           .Pause();
        VM1.GameOver             .Pause();
        VM1.Win                  .Pause();
    }
    void Update()
    {
        CurrentTime -= 1 * Time.deltaTime;
        CountDownText.text = "" + CurrentTime.ToString("00");
        if (CurrentTime <= 0)
        {
            CurrentTime = 0;
            Time.timeScale = 0f;
            GameOverMenu             .SetActive(true);
            PauseMenu                .SetActive(false);
            PauseButton              .SetActive(false);
            WinMenu                  .SetActive(false);
            VM1.WinVideoPanel        .SetActive(false);
            VM1.GameOverVideoPanel   .SetActive(true);
            VM1.PauseVideoPanel      .SetActive(false);
            VM1.StartVideoPanel      .SetActive(false);
            VM1.PauseVideo           .Pause();
            VM1.GameOver             .Play();
            VM1.Win                  .Pause();

        }
    }
    
    public void Pause()
    {
        Time.timeScale = 0f;
        GameOverMenu             .SetActive(false);
        PauseMenu                .SetActive(true);
        PauseButton              .SetActive(false);
        WinMenu                  .SetActive(false);
        VM1.WinVideoPanel        .SetActive(false);
        VM1.GameOverVideoPanel   .SetActive(false);
        VM1.PauseVideoPanel      .SetActive(true);
        VM1.StartVideoPanel      .SetActive(false);
        VM1.PauseVideo           .Play();
        VM1.GameOver             .Pause();
        VM1.Win                  .Pause();
    }
    public void Reume()
    {
        Time.timeScale = 1f;
        PauseMenu                .SetActive(false);
        GameOverMenu             .SetActive(false);
        PauseButton              .SetActive(true);
        VM1.WinVideoPanel        .SetActive(false);
        VM1.GameOverVideoPanel   .SetActive(false);
        VM1.PauseVideoPanel      .SetActive(false);
        VM1.StartVideoPanel      .SetActive(true);
        VM1.PauseVideo           .Pause();
        VM1.GameOver             .Pause();
        VM1.Win                  .Pause();
    }

    public void restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(CurrentIndex);
        Time.timeScale = 1f;
        GameOverMenu             .SetActive(false);
        VM1.WinVideoPanel        .SetActive(false);
        VM1.GameOverVideoPanel   .SetActive(false);
        VM1.PauseVideoPanel      .SetActive(false);
        VM1.StartVideoPanel      .SetActive(false);
        VM1.PauseVideo           .Pause();
        VM1.GameOver             .Pause();
        VM1.Win                  .Pause();
    }
    private void Win()
    {
        WinMenu      .SetActive(true);
        PauseButton              .SetActive(false);
        VM1.WinVideoPanel        .SetActive(true);
        VM1.GameOverVideoPanel   .SetActive(false);
        VM1.PauseVideoPanel      .SetActive(false);
        VM1.StartVideoPanel      .SetActive(false);
        VM1.PauseVideo           .Pause();
        VM1.GameOver             .Pause();
        VM1.Win                  .Play();
        Time.timeScale = 0f;
    }
    public void Quit()
    {
        Application.Quit();   
    }
}
