using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Public fields
    public GameObject target;
    public float scale = 4f;

    // Private fields
    private Transform t;

    void Awkake()
    {
        // Set camera value before starting game
        var cam = GetComponent<Camera>();
        cam.orthographicSize = (Screen.height / 2f) / scale;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Assign value to fields
        t = target.transform;

    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            // Follow target position
            transform.position = new Vector3(t.position.x, t.position.y, transform.position.z);
        }
        
    }
}
