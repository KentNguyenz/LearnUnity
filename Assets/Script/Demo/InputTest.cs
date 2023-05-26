using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    private float directionX;
    private float directionY;
    // Update is called once per frame
    void Update()
    {
        directionX = Input.GetAxis("Horizontal");
        Debug.Log(directionX);
        directionY = Input.GetAxis("Vertical");
        Debug.Log(directionY);
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
        }
        if (Input.GetButton("Jump"))
        {
            Debug.Log("Jump is held down");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left mouse click");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Left mouse held down");
        }
        if(Input.GetKey(KeyCode.G))
        {
            Debug.Log("G is Pressed");
        }
    }
}
