using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IInput))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class Character : Destructible
{
    private IInput input;
    private Vector2 mousePos, moveInput, lookDirection;
    private bool mouseLeftClick, mouseRightClick;
    private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 50f, meleeRange = 1f;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<IInput>();
        rb = GetComponent<Rigidbody2D>();
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

        LookAtTarget();
        if (mouseLeftClick) AttackPrimary();
        else if(mouseRightClick) AttackAlternate();
    }

    // FixedUpdate is called once per physics cycle
    private void FixedUpdate()
    {
        rb.velocity = moveSpeed * Time.fixedDeltaTime * moveInput;
    }

    // Look at target(mouse)
    private void LookAtTarget()
    {
        lookDirection = mousePos - new Vector2(transform.position.x, transform.position.y); //subtract character location from mouse position to get a look vector
        lookDirection = lookDirection.normalized; //make vector have a magnitude of one.
        float zRotation = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg + 90; //calculate rotation and add 90 because the icon is facing south.
        //Debug.Log(zRotation);
        transform.SetPositionAndRotation(transform.position, Quaternion.Euler(0f, 0f, zRotation)); //set rotation of gameObject
    }

    private void AttackPrimary()
    {
        float radius = GetComponent<CircleCollider2D>().radius;
        RaycastHit2D[] results = Physics2D.CircleCastAll(transform.position, radius, lookDirection, meleeRange);
        int i = 0;
        foreach (RaycastHit2D result in results)
        {
            Debug.Log(i + ": " + result.transform.ToString());
            i++;
        }
        //raycastHit2D.collider.GetComponent<Destructible>();
    }

    private void AttackAlternate()
    {

    }
}
