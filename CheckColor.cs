using NUnit.Framework.Internal;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class CheckColor : MonoBehaviour
{
    private Color[] otherGameObjectColors = new Color[3] { Color.green, Color.yellow, Color.red };
    private Color[] thisGameObjectColors = new Color[3] { Color.green, Color.yellow, Color.red };
    public int greenScore;
    public int yellowScore;
    public int redScore;


    public GameObject greenScoreBoard;
    public GameObject yellowScoreBoard;
    public GameObject redScoreBoard;
    private int maxScore = 5;


    void OnTriggerEnter2D(Collider2D collision)
    {

        //Makes a reference to the SpriteRenderer of the colliding gameObject
        SpriteRenderer otherSpriteRenderer = collision.gameObject.GetComponent<SpriteRenderer>();
        //Makes a referenece to the Color of the colliding gameObject
        Color collidingObjectColor = otherSpriteRenderer.color;

        //Makes a reference to the SpriteRenderer of the gameObject this script is attached to
        SpriteRenderer thisSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        //Makes a reference to the color of the gameObject this script is attached to
        Color thisObjectColor = thisSpriteRenderer.color;


        void GreenScoreboardText()
        {
            greenScoreBoard.GetComponent<TextMeshProUGUI>().SetText($"{greenScore}");
        }

        void YellowScoreboardText()
        {
            yellowScoreBoard.GetComponent<TextMeshProUGUI>().SetText($"{yellowScore}");
        }

        void RedScoreboardText()
        {
            redScoreBoard.GetComponent<TextMeshProUGUI>().SetText($"{redScore}");
        }


        //GREEN SCORE CHECK\\
        if (otherSpriteRenderer != null && thisObjectColor == thisGameObjectColors[0] && collision.gameObject.tag == "Sphere" && collidingObjectColor == otherGameObjectColors[0])
        {
            greenScore++;
            Debug.Log("Colliding object is green!");
            GreenScoreboardText();
            Goal();
        }

        else if (otherSpriteRenderer != null && thisObjectColor == thisGameObjectColors[0] && collision.gameObject.tag == "Sphere" && collidingObjectColor != otherGameObjectColors[0])
        {
            greenScore = 0;
            Debug.Log("Wrong Color");
            GreenScoreboardText();
        }





        //YELLOW SCORE CHECK\\
        if (otherSpriteRenderer != null && thisObjectColor == thisGameObjectColors[1] && collision.gameObject.tag == "Sphere" && collidingObjectColor == otherGameObjectColors[1])
        {
            yellowScore++;
            Debug.Log("Colliding object is yellow!");
            YellowScoreboardText();
            Goal();
        }
        else if (otherSpriteRenderer != null && thisObjectColor == thisGameObjectColors[1] && collision.gameObject.tag == "Sphere" && collidingObjectColor != otherGameObjectColors[1])
        {
            yellowScore = 0;
            Debug.Log("Wrong Color");
            YellowScoreboardText();
        }





        //RED SCORE CHECK\\
        if (otherSpriteRenderer != null && thisObjectColor == thisGameObjectColors[2] && collision.gameObject.tag == "Sphere" && collidingObjectColor == otherGameObjectColors[2])
        {
            redScore++;
            RedScoreboardText();
            Goal();
        }
        else if (otherSpriteRenderer != null && thisObjectColor == thisGameObjectColors[2] && collision.gameObject.tag == "Sphere" && collidingObjectColor != otherGameObjectColors[2])
        {
            redScore = 0;
            Debug.Log("Wrong Color");
            RedScoreboardText();
        }




        void Goal()
        {
            if (greenScore == maxScore || yellowScore == maxScore || redScore == maxScore)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}