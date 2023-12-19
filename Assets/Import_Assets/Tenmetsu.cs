using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tenmetsu : MonoBehaviour
{
    MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        StartCoroutine("Blink");
    }

    IEnumerator Blink()
    {
        while (true)
        {
            for (int i = 0; i < 100; i++)
            {
                mesh.material.color = mesh.material.color - new Color32(0, 0, 0, 1);
            }

            yield return new WaitForSeconds(0.2f);

            for (int k = 0; k < 100; k++)
            {
                mesh.material.color = mesh.material.color + new Color32(0, 0, 0, 1);
            }

            yield return new WaitForSeconds(0.2f);

        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
