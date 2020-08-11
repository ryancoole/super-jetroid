using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookForward : MonoBehaviour
{
    // Public fields
    public Transform sightStart, sightEnd;
    public string layer = "Solid";
    public bool needsCollision = true;

    // Private fields
    private bool collision;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        collision = Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer(layer));

        // Line for debugging
        Debug.DrawLine(sightStart.position, sightEnd.position, Color.green);

        if (collision == needsCollision)
        {
            transform.localScale = new Vector3(transform.localScale.x == 1 ? -1 : 1, 1, 1);
        }
    }
}
