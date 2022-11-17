using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;
    public GameObject closeBut;
    public AudioSource ClickSound;
    
    public void Click()
    {
        ClickSound.Play();
        PlayerPrefs.SetString("Sphere", PlayerPrefs.GetString("Choose"));
        switch (PlayerPrefs.GetString("Page"))
        {
            case "Page1":page1.SetActive(true);
                break;
            case "Page2":page2.SetActive(true);
                break;
            case "Page3":page3.SetActive(true);
                break;
            case "Page4":page4.SetActive(true);
                break;
        }
        //page1.SetActive(true);
        closeBut.SetActive(true);
    }
}
