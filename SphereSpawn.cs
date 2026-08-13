using System;
using Unity.VisualScripting;
using UnityEngine;

public class SphereSpawn : MonoBehaviour
{
    public GameObject sphere;

    void Start()
    {
        spawnGo();
    }

    public void spawnGo()
    {
        GameObject.Instantiate(sphere);
    }

    void Update()
    {
        //TODO: MAKe it to where:
        // If gameobject that is the SPHERE 
        // SELF DELETES,
        // Run spawnGo Function. 
        // HOW DO I????
    }
}
