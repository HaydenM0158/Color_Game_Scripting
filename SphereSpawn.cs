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
}
