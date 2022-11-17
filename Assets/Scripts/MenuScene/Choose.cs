using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choose : MonoBehaviour
{
   public GameObject sphere;
   public GameObject mainSphere;
   public GameObject Ok;
   public GameObject choose;
   public GameObject menuSphere;
   public GameObject page;
   public AudioSource ClickSound;
   
   public void Click()
   {
      ClickSound.Play();
      PlayerPrefs.SetString("Choose", tag);
      PlayerPrefs.SetString("Page", page.tag);
      mainSphere.GetComponent<SpriteRenderer>().sprite = sphere.GetComponent<SpriteRenderer>().sprite;
      menuSphere.GetComponent<SpriteRenderer>().sprite = sphere.GetComponent<SpriteRenderer>().sprite;
      choose.SetActive(false);
      Ok.SetActive(true);
   }
}
