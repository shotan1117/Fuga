using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SearchBlock : MonoBehaviour
{
    public GameObject Player;
    public GameObject Break;

    public GameObject Book;
    Book script;



    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        Break = GameObject.Find("break");
        Book = GameObject.Find("book_0001c");
        script = Book.GetComponent<Book>();
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
         script.isInPlayer = true;
    }
    private void OnTriggerExit(Collider other)
    {
        script.isInPlayer = false;
    }
}
