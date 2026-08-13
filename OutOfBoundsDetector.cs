using Unity.VisualScripting;
using UnityEngine;

public class OutOfBoundsDetector : MonoBehaviour
{
    public GameObject sphere;
    float yBounds = -10;

    // Update is called once per frame
    void Update()
    {
        if (sphere.transform.position.y < yBounds)
        {
            Debug.Log("Does this fucking work??");
            GameObject.Destroy(sphere);
        }
    }
}
