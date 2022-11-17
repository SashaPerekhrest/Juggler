using UnityEngine;

public class Buy : MonoBehaviour
{
    public GameObject choose;
    public GameObject buy;
    public AudioSource ClickSound;
    
    public void Click()
    {
        ClickSound.Play();
        
        var sale = 0;
        switch (tag)
        {
            case "Sphere1":
                sale = 0;
                break;
            case "Sphere2":
                sale = 20;
                break;
            case "Sphere3":
                sale = 40;
                break;
            case "Sphere4":
                sale = 100;
                break;
            case "Sphere5":
                sale = 150;
                break;
            case "Sphere6":
                sale = 200;
                break;
            case "Sphere7":
                sale = 300;
                break;
            case "Sphere8":
                sale = 500;
                break;
            case "Sphere9":
                sale = 500;
                break;
            case "Sphere10":
                sale = 500;
                break;
            case "Sphere11":
                sale = 500;
                break;
            case "Sphere12":
                sale = 500;
                break;
            case "Sphere13":
                sale = 1000;
                break;
            case "Sphere14":
                sale = 1000;
                break;
            case "Sphere15":
                sale = 1000;
                break;
            case "Sphere16":
                sale = 1000;
                break;
        }
        if (PlayerPrefs.GetInt("Money") >= sale)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - sale);
            PlayerPrefs.SetInt(tag, 1);
            buy.SetActive(false);
            choose.SetActive(true);
        }

    }
}
