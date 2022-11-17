using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextPage : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;
    public AudioSource ClickSound;
    
    public void Click()
    {
        ClickSound.Play();
        page1.SetActive(false);
        page2.SetActive(true);
    }
}
