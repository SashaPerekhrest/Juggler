using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float rot = 0;
    public GameObject sphere;

    public void Awake()
    { 
        GetComponent<SpriteRenderer>().sprite = sphere.GetComponent<SpriteRenderer>().sprite;
    }

    void Update()
    {
        transform.rotation = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(0f, 0f, rot), Time.time);
        rot += 75f * Time.deltaTime;
    }
}
