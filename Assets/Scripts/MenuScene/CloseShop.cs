using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseShop : MonoBehaviour
{
    public GameObject shopBg;
    public AudioSource ClickSound;
    
    public void Click()
    {
        ClickSound.Play();
        shopBg.SetActive(false);
    }
}
