using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscToRestart : MonoBehaviour
{
    // Public field
    public string scene;

    // Private field
    private bool loadLock;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Load scene on click
        if (Input.GetMouseButtonDown(0) && !loadLock)
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        loadLock = true;
        SceneManager.LoadScene(scene);
    }
}
