using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    private string loadScene;
    private Color fadeColor = Color.black;
    private float fadeSpeedMultiplier = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        loadScene = "Load";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Initiate.Fade(loadScene, fadeColor, fadeSpeedMultiplier);
        }
    }
}
