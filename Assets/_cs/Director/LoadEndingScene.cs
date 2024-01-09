using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    private string loadScene;
    private Color fadeColor = Color.white;
    private float fadeSpeedMultiplier = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        loadScene = "Ending";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter()
    {
        Initiate.Fade(loadScene, fadeColor, fadeSpeedMultiplier);
    }
}
