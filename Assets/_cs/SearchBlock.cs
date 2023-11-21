using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SearchBlock : MonoBehaviour
{
    public GameObject Player;
    public GameObject Break;
    public GameObject Bed;
    Bed script;



    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        Break = GameObject.Find("break");
        Bed = GameObject.Find("Bed_Apt_02_01");
        script = Bed.GetComponent<Bed>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
         script.isBreak = true;
         Debug.Log("true‚É‚µ‚½");
      


    }
}
