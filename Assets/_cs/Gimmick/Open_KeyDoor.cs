using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_KeyDoor : MonoBehaviour
{
    public Animator openandclose;
    public bool open;
    public PadLock target;


    // Start is called before the first frame update
    void Start()
    {
        open = false;
    }

    private void OnDisable()
    {
        target.OnDestroyed.RemoveAllListeners();
    }

    private void OnEnable()
    {
        target.OnDestroyed.AddListener(() =>
        {
            Debug.Log("target‚ªíœ‚³‚ê‚Ü‚µ‚½");
            StartCoroutine(opening());
        });
    }

    IEnumerator opening()
    {
        openandclose.Play("Opening");
        open = true;
        yield return new WaitForSeconds(0.5f);
    }
}
