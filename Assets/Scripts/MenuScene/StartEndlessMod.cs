using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEndlessMod : MonoBehaviour
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
        ClickSound.Play();
        Game.arcadeMod = false;
        anim.SetBool("start",true);
        StartCoroutine(StartEnd ());
    }

    public void ArcadeST()
    {
        ClickSound.Play();
        Game.arcadeMod = true;
        anim.SetBool("start", true);
        StartCoroutine(StartEnd());
    }

    IEnumerator StartEnd()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("main");
    }
}
