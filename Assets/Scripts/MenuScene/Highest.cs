using UnityEngine;
using UnityEngine.UI;

public class Highest : MonoBehaviour
{
    public Text text;
    void Update()
    {
        if (tag == "Arcade Mod")
            text.text = "High score: " + PlayerPrefs.GetInt("HighestArcade");
        else text.text = "High score: " + PlayerPrefs.GetInt("Highest");
    }
}
