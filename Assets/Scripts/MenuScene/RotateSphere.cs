using UnityEngine;

public class RotateSphere : MonoBehaviour
{
    private float rot = 0;
    public GameObject buyBut;
    public GameObject chooseBut;
    public GameObject Ok;
    void Update()
    {
        if (PlayerPrefs.GetString("Sphere") == tag)
        {
            transform.rotation = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(0f, 0f, rot), Time.time);
            rot += 75f * Time.deltaTime * 2f;
            
            if (PlayerPrefs.GetInt(tag) == 0)
            {
               buyBut.SetActive(true);
            }
            else if (PlayerPrefs.GetString("Choose") != tag)
            {
                chooseBut.SetActive(true);
            }
            else
            {
                Ok.SetActive(true);
            }
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            rot = 0f;
            buyBut.SetActive(false);
            chooseBut.SetActive(false);
            Ok.SetActive(false);
        }
    }
}
