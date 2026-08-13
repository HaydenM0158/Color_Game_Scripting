using UnityEngine;

public class SphereRespawn : MonoBehaviour
{
    [SerializeField] GameObject sphere;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            GameObject.Destroy(collision.gameObject);
            GameObject.Instantiate(sphere);
        }
    }
}
