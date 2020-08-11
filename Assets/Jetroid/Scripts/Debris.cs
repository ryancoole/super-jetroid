using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour
{
    // Private fields
    private SpriteRenderer renderer2D;
    private Color start;
    private Color end;
    private float t = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // Assign value to fields
        renderer2D = GetComponent<SpriteRenderer>();
        start = renderer2D.color;
        end = new Color(start.r, start.g, start.b, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Consistent time change from frame to frame
        t += Time.deltaTime;

        renderer2D.material.color = Color.Lerp(start, end, t / 2);

        // Debris will disappear after time
        if (renderer2D.material.color.a <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
