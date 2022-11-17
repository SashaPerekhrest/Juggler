using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{ 
    public Text text;
    void Update()
    {
        if (Game.arcadeMod)
            text.text = "High score: " + PlayerPrefs.GetInt("HighestArcade");
        else text.text = "High score: " + PlayerPrefs.GetInt("Highest");
    }
}
