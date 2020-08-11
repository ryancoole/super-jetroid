using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    // Public fields
    public Sprite[] sprites;
    public int currentSprite = -1;

    // Start is called before the first frame update
    void Start()
    {
        // Give sprite random color unless 1 or greater
        if(currentSprite == -1)
        {
            currentSprite = Random.Range(0, sprites.Length);
        }

        else if (currentSprite > sprites.Length)
        {
            currentSprite = sprites.Length - 1;
        }

        GetComponent<SpriteRenderer>().sprite = sprites[currentSprite];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
