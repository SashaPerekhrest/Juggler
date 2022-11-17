using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject mainSphere;
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere4;
    public GameObject sphere5;
    public GameObject sphere6;
    public GameObject sphere7;
    public GameObject sphere8;
    public GameObject sphere9;
    public GameObject sphere10;
    public GameObject sphere11;
    public GameObject sphere12;
    public GameObject sphere13;
    public GameObject sphere14;
    public GameObject sphere15;
    public GameObject sphere16;
    public GameObject sphereM;
    
    void Start()
    {
        //PlayerPrefs.SetInt("HighestArcade", 0);
        //PlayerPrefs.SetInt("Highest", 0);
        //PlayerPrefs.SetInt("Sphere2", 0);
        //PlayerPrefs.SetInt("Sphere3", 0);
        //PlayerPrefs.SetInt("Sphere4", 0);
        //PlayerPrefs.SetInt("Sphere5", 0);
        //PlayerPrefs.SetInt("Sphere6", 0);
        //PlayerPrefs.SetInt("Sphere7", 0);
        //PlayerPrefs.SetInt("Sphere8", 0);
        //PlayerPrefs.SetInt("Sphere9", 0);
        //PlayerPrefs.SetInt("Sphere10", 0);
        //PlayerPrefs.SetInt("Sphere11", 0);
        //PlayerPrefs.SetInt("Sphere12", 0);
        //PlayerPrefs.SetInt("Sphere13", 0);
        //PlayerPrefs.SetInt("Sphere14", 0);
        //PlayerPrefs.SetInt("Sphere15", 0);
        //PlayerPrefs.SetInt("Sphere16", 0);
        //PlayerPrefs.SetInt("Money", 0);
        //PlayerPrefs.SetString("Page", "Page1");
        
        if (!PlayerPrefs.HasKey("Highest"))
            PlayerPrefs.SetInt("Highest", Game.Score);
        if (!PlayerPrefs.HasKey("HighestArcade"))
            PlayerPrefs.SetInt("HighestArcade", Game.Score);
        if (!PlayerPrefs.HasKey("Money"))
            PlayerPrefs.SetInt("Money", 0);
        if (!PlayerPrefs.HasKey("Page"))
            PlayerPrefs.SetString("Page", "Page1");
        
        if (!PlayerPrefs.HasKey("Choose"))
            PlayerPrefs.SetString("Choose", "Sphere1");
        else
            switch (PlayerPrefs.GetString("Choose"))
            {
                case "Sphere1":
                    SpriteChange(sphere1);
                    break;
                case "Sphere2":
                    SpriteChange(sphere2);
                    break;
                case "Sphere3":
                    SpriteChange(sphere3);
                    break;
                case "Sphere4":
                    SpriteChange(sphere4);
                    break;
                case "Sphere5":
                    SpriteChange(sphere5);
                    break;
                case "Sphere6":
                    SpriteChange(sphere6);
                    break;
                case "Sphere7":
                    SpriteChange(sphere7);
                    break;
                case "Sphere8":
                    SpriteChange(sphere8);
                    break;
                case "Sphere9":
                    SpriteChange(sphere9);
                    break;
                case "Sphere10":
                    SpriteChange(sphere10);
                    break;
                case "Sphere11":
                    SpriteChange(sphere11);
                    break;
                case "Sphere12":
                    SpriteChange(sphere12);
                    break;
                case "Sphere13":
                    SpriteChange(sphere13);
                    break;
                case "Sphere14":
                    SpriteChange(sphere14);
                    break;
                case "Sphere15":
                    SpriteChange(sphere15);
                    break;
                case "Sphere16":
                    SpriteChange(sphere16);
                    break;
            }


        PlayerPrefs.SetInt("Sphere1", 1);
        if (!PlayerPrefs.HasKey("Sphere2"))
            PlayerPrefs.SetInt("Sphere2", 0);
        if (!PlayerPrefs.HasKey("Sphere3"))
            PlayerPrefs.SetInt("Sphere3", 0);
        if (!PlayerPrefs.HasKey("Sphere4"))
            PlayerPrefs.SetInt("Sphere4", 0);
        if (!PlayerPrefs.HasKey("Sphere5"))
            PlayerPrefs.SetInt("Sphere5", 0);
        if (!PlayerPrefs.HasKey("Sphere6"))
            PlayerPrefs.SetInt("Sphere6", 0);
        if (!PlayerPrefs.HasKey("Sphere7"))
            PlayerPrefs.SetInt("Sphere7", 0);
        if (!PlayerPrefs.HasKey("Sphere8"))
            PlayerPrefs.SetInt("Sphere8", 0);
        if (!PlayerPrefs.HasKey("Sphere9"))
            PlayerPrefs.SetInt("Sphere9", 0);
        if (!PlayerPrefs.HasKey("Sphere10"))
            PlayerPrefs.SetInt("Sphere10", 0);
        if (!PlayerPrefs.HasKey("Sphere11"))
            PlayerPrefs.SetInt("Sphere11", 0);
        if (!PlayerPrefs.HasKey("Sphere12"))
            PlayerPrefs.SetInt("Sphere12", 0);
        if (!PlayerPrefs.HasKey("Sphere13"))
            PlayerPrefs.SetInt("Sphere13", 0);
        if (!PlayerPrefs.HasKey("Sphere14"))
            PlayerPrefs.SetInt("Sphere14", 0);
        if (!PlayerPrefs.HasKey("Sphere15"))
            PlayerPrefs.SetInt("Sphere15", 0);
        if (!PlayerPrefs.HasKey("Sphere16"))
            PlayerPrefs.SetInt("Sphere16", 0);
    }

    private void SpriteChange(GameObject toChange)
    {
        mainSphere.GetComponent<SpriteRenderer>().sprite = toChange.GetComponent<SpriteRenderer>().sprite;
        sphereM.GetComponent<SpriteRenderer>().sprite = toChange.GetComponent<SpriteRenderer>().sprite;
    }
}
