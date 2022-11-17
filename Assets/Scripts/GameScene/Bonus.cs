using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 2f;

    void Update()
    {
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime,0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "LeftArm")
        {
            if (tag == "Heart")
                Game.Lives++;
            if (tag == "Clock")
                MoveSphere.fallSpeed = 3f;
            if (tag == "Shield")
                MoveSphere.shield = true;

            Destroy(gameObject);
        }
    }
}
