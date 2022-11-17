using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
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
    StartCoroutine(RestartGame ());
  }

  IEnumerator RestartGame()
  {
    yield return new WaitForSeconds(2f);
    SceneManager.LoadScene("main");
  }
}
