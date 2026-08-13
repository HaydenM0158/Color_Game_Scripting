using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
//using UnityEngine.WSA;
using System.Collections;
public class mouseMove : MonoBehaviour
{
    bool mouseCollision;

    
    void OnMouseEnter()
    {
        mouseCollision = true;
        Debug.Log("Hi, you made it!");
    }

    void MouseInput()
    {
        if (mouseCollision == true)
        {
            if (Input.GetMouseButton(0))
            {
                Vector2 mouseCursor = Input.mousePositionDelta;
                mouseCursor = mouseCursor.normalized * mouseCursor.magnitude;

                //WORKING PROTOTYPE, IT KINDA WORKS, FOR THE LOVE OF GOD DON'T DELETE THIS LINE OF CODE!!!!
                //gameObject.GetComponent<Rigidbody2D>().AddForce(mouseCursor * mouseMoveSpeed * Time.deltaTime);
                gameObject.GetComponent<Rigidbody2D>().AddForceAtPosition(mouseCursor, mouseCursor * Time.deltaTime);

                gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;

                Debug.Log("Grabby");
            }

            if (Input.GetMouseButtonUp(0))
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
                Debug.Log("It Works I Guess");
            }
        }
    }


    void Update()
    {
        //This is for if I need to test the game at a lower frame rate; in this case 10 frames BUT that value can be adjusted.
        //UnityEngine.Application.targetFrameRate = 10;
        MouseInput();
    }
}
