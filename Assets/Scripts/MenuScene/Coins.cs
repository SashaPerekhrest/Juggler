using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text text;
    void Update()
    {
        text.text = PlayerPrefs.GetInt("Money").ToString();
    }
}
