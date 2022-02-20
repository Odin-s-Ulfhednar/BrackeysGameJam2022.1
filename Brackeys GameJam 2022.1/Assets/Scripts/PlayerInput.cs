using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour, IInput
{
    public bool GetMouseClickLeft()
    {
        return Input.GetMouseButton(0);
        //throw new System.NotImplementedException();
    }

    public bool GetMouseClickRight()
    {
        return Input.GetMouseButton(1);
        //throw new System.NotImplementedException();
    }

    public Vector2 GetMousePos()
    {
        Vector2 output = Vector2.zero;
        Vector3 temp = Input.mousePosition;
        //Debug.Log(temp);
        output = Camera.main.ScreenToWorldPoint(temp);
        //Debug.Log(Camera.main.ScreenToWorldPoint(temp));
        //Debug.Log(output);
        return output;
        //throw new System.NotImplementedException();
    }

    public Vector2 GetMovement()
    {
        Vector2 output = Vector2.zero;
        output.x = Input.GetAxis("Horizontal");
        output.y = Input.GetAxis("Vertical");
        return output;
        //throw new System.NotImplementedException();
    }
}
