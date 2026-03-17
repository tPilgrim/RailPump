using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Animator Anim;
    public AudioSource Audio;
    public GameObject SettingsPanel;
    public Text ScoreText;

    void Start()
    {
        ScoreText.text = PlayerPrefs.GetInt("Score").ToString("0");
    }

    public void Play()
    {
        Anim.SetTrigger("Transition");
        StartCoroutine(StartTransition());
    }

    public void OpenSettings()
    {
        SettingsPanel.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Back()
    {
        SettingsPanel.SetActive(false);
    }

    IEnumerator StartTransition()
    {
        while(Audio.volume > 0)
        {
            Audio.volume -= Time.deltaTime / 4;
        }
        yield return new WaitForSeconds(1.25f);
        SceneManager.LoadScene(1);
    }
}
