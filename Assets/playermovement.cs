using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    Entity entity;
     Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MEOW!");
        entity = GetComponent<Entity>();
    }

    void OnMove(InputValue value)
    {
        dir = value.Get<Vector2>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = dir * entity.stats.MovementSpeed;
    }
}
