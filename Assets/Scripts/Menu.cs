using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Animator Anim;

    public void Resume()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {

    }

    public void TitleScreen()
    {
        Anim.SetTrigger("Transition");
        StartCoroutine(StartTransition());
        Time.timeScale = 1f;
    }

    IEnumerator StartTransition()
    {
        yield return new WaitForSeconds(1.25f);
        SceneManager.LoadScene(0);
    }
}
