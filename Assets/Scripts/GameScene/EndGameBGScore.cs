using UnityEngine;
using UnityEngine.UI;

public class EndGameBGScore : MonoBehaviour
{
    public Text textS;
    public Text textH;
    void Update()
    {
        textS.text = Game.Score.ToString();
        if (Game.arcadeMod)
            textH.text = PlayerPrefs.GetInt("HighestArcade").ToString();
        else textH.text = PlayerPrefs.GetInt("Highest").ToString();
    }
}
