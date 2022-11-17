using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialScript : MonoBehaviour
{
    public GameObject tutorialBg;
    public AudioSource ClickSound;
    
    public void Click()
    {
        ClickSound.Play();
        tutorialBg.SetActive(true);
    }
}
