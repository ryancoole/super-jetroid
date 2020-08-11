using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public fields
    public Vector2 moving = new Vector2();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Reset moving to 0 after every frame
        moving.x = moving.y = 0;

        // If user presses D
        if (Input.GetKey(KeyCode.D))
        {
            moving.x = 1;
        }

        // If user presses A
        else if (Input.GetKey(KeyCode.A))
        {
            moving.x = -1;
        }

        // If user presses space bar
        if (Input.GetKey(KeyCode.Space))
        {
            moving.y = 1;
        }
    }
}
