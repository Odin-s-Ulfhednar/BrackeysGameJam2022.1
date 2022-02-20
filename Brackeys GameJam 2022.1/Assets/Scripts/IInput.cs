using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInput
{
    Vector2 GetMovement();
    Vector2 GetMousePos();
    bool GetMouseClickLeft();
    bool GetMouseClickRight();
}
