using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// All characters will have an IInput interface so that the Character class can get input in some way.
public interface IInput
{
    Vector2 GetMovement();
    Vector2 GetMousePos();
    bool GetMouseClickLeft();
    bool GetMouseClickRight();
}
