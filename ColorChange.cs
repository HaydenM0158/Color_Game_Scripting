using System;
using static System.Random;
using static UnityEngine.Random;
using UnityEngine;
using Unity.Mathematics;
//using UnityEditor.ShaderGraph;
using Unity.VisualScripting;

public class ColorChange : MonoBehaviour
{

    public Color[] colors = { Color.green, Color.yellow, Color.red };


    public void ColorAssignment()
    {
        gameObject.GetComponent<SpriteRenderer>().color = colors[UnityEngine.Random.Range(0, colors.Length)];
    }

    void Start()
    {
        ColorAssignment();
    }
}