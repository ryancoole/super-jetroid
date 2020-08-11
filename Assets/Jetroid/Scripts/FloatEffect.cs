using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatEffect : MonoBehaviour
{
    // Private field
    private float startY = 0f;
    private float duration = 1f;
    private RectTransform rectTransform;

    // Start is called before the first frame update
    void Start()
    {
        // Assign value to fields
        rectTransform = GetComponent<RectTransform>();
        startY = rectTransform.anchoredPosition.y;

    }

    // Update is called once per frame
    void Update()
    {
        // Move game object
        var newY = startY + (startY + Mathf.Cos(Time.time / duration * 2)) / .1f;
        rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, newY);
    }
}
