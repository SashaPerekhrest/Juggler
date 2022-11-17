using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class MoneyScript : MonoBehaviour
{
    public Text text;
    public GameObject doubleButton;
    private bool show;
    void Update()
    {
        text.text = Game.Coin.ToString();
        if (Game.Coin == 0)
            doubleButton.SetActive(false);
        else if (!show)
            doubleButton.SetActive(true);
        else
        {
            doubleButton.SetActive(false);
        }
    }
    
    public void DoubleCoin()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo");
            Game.Coin = Game.Coin * 2;
            doubleButton.SetActive(false);
            show = true;
        }
    }
}