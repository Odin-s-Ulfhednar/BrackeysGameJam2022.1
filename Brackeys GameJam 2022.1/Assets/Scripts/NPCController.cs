using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    private IInput input;
    private Vector2 mousePos, moveInput;
    private bool mouseLeftClick, mouseRightClick;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<IInput>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = input.GetMovement();
        //Debug.Log("Movement: " + moveInput);

        mousePos = input.GetMousePos();
        //Debug.Log("Mouse World Pos: " + mousePos);

        mouseLeftClick = input.GetMouseClickLeft();
        //Debug.Log("Left Click: " + mouseLeftClick);

        mouseRightClick = input.GetMouseClickRight();
        //Debug.Log("Right Click: " + mouseRightClick);

    }
}
