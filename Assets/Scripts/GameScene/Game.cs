using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using System.Collections;


public class Game : MonoBehaviour
{
   public static bool lose = false;
   public GameObject endBG;
   public GameObject playButton;
   public GameObject left;
   public GameObject right;
   public static int Score = 0;
   public static int CountGame = 0;
   public static int Coin, Lives;
   public static bool arcadeMod;
   public static bool pause;
   public GameObject heart;
   public Text countHeart;
   public GameObject hero;
   public GameObject scoreBG;
   public Text gameOverTxt;
   private Animator animHero;
   private Animator scoreBGAnim;
   private Animator endBGAnim;

   public Sprite shield;
   public Sprite clock;
   public GameObject icon;

   private void Start()
   {
      if (Advertisement.isSupported)
      {
         Advertisement.Initialize("3935053", false);
      }

      CountGame++;
      if (Advertisement.IsReady() && CountGame >= 4)
      {
         CountGame = 0;
         Advertisement.Show("video");
      }
   }

   private void Awake()
   {
      if (arcadeMod)
      {
         heart.SetActive(true);
         Lives = 5;
         countHeart.text = Lives.ToString();
      }

      MoveSphere.fallSpeed = 6f;
      lose = false;
      Score = 0;
      Coin = 0;
      animHero = hero.GetComponent<Animator>();
      scoreBGAnim = scoreBG.GetComponent<Animator>();
      endBGAnim = endBG.GetComponent<Animator>();
      MoveSphere.shield = false;
   }

   private void Update()
   {
      if (!PlayerPrefs.HasKey("Highest"))
         PlayerPrefs.SetInt("Highest", Score);
      if (!PlayerPrefs.HasKey("HighestArcade"))
         PlayerPrefs.SetInt("HighestArcade", Score);
      if (!PlayerPrefs.HasKey("Money"))
         PlayerPrefs.SetInt("Money", 0);
      if (lose)
      {
         playButton.SetActive(false);
         left.SetActive(false);
         right.SetActive(false);
         endBG.SetActive(true);
         animHero.SetBool("Lose", true);
         scoreBGAnim.SetBool("Lose", true);
         endBGAnim.SetBool("Open", true);
         if ((PlayerPrefs.GetInt("Highest") == Score || (PlayerPrefs.GetInt("HighestArcade") == Score && arcadeMod)) && Score != 0)
         {
            gameOverTxt.text = "New record";
            endBGAnim.SetBool("NewRecord", true);
            animHero.SetBool("New", true);
         }
      }
      countHeart.text = Lives.ToString();

      if (MoveSphere.fallSpeed == 3f)
      {
         icon.GetComponent<Image>().sprite = clock;
         icon.SetActive(true);
         StartCoroutine(BackClock());
      }

      if (MoveSphere.shield)
      { 
         icon.GetComponent<Image>().sprite = shield;
         icon.SetActive(true);
         StartCoroutine(BackShield());
      }
   }
   
   IEnumerator BackClock()
   {
      yield return new WaitForSeconds(6f);
      MoveSphere.fallSpeed = 6f;
      icon.SetActive(false);
      StopCoroutine(BackClock());
   }
    
   IEnumerator BackShield()
   {
      yield return new WaitForSeconds(6f);
      MoveSphere.shield = false;
      icon.SetActive(false);
      StopCoroutine(BackShield());
   }
}
