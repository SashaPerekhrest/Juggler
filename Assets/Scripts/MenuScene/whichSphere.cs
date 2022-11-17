using UnityEngine;

public class whichSphere : MonoBehaviour
{
    public GameObject mainSphere;
    private void OnMouseDown()
    {
        PlayerPrefs.SetString("Sphere", tag);
    }
}
