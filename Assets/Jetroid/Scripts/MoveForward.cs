using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Public fields
    public float speed = 10f;

    // Private fields
    private Rigidbody2D body2D;

    // Start is called before the first frame update
    void Start()
    {
        // Assign value to fields
        body2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body2D.velocity = new Vector2(transform.localScale.x, 0) * speed;

    }
}
