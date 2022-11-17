using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{ 
    private Animator anim;
    public GameObject zanawes;
    public AudioSource ClickSound;
    
    private void Start()
    {
        anim = zanawes.GetComponent<Animator>();
    }

    public void Click()
    {
        if (Game.lose)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + Game.Coin);
        }

        Time.timeScale = 1f;
        ClickSound.Play();
        anim.SetBool("start",true);
        StartCoroutine(StartEnd ());
    }

    IEnumerator StartEnd()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("menu");
    }
}
