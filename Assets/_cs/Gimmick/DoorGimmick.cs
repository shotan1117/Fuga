using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGimmick : MonoBehaviour
{
    public Animator openandclose;
    public bool open;
    public Transform Player;

    [SerializeField]
    AudioClip openclip;

    bool firstFlag;
    private AudioSource audiosource;

    [SerializeField] int textNo;

    public GameObject board;
    void Start()
    {
        open = false;
        audiosource = GetComponent<AudioSource>();
    }

    void OnMouseOver()
    {
        if (Player)
        {
            float dist = Vector3.Distance(Player.transform.position, transform.position);
            if (dist < 3.5f)
            {
                if (Input.GetKeyDown(InputManeger.Instance.Key[5]) && board == null)
                {
                    if (open == false)
                    {
                        StartCoroutine(opening());
                      
                    }
                    else
                    {
                        StartCoroutine(closing());
                    }

                    if (firstFlag == false)
                    {
                        GManager.Instances.HintMSG(textNo);
                        firstFlag = true;
                    }

                }
            }
        }
    }

    IEnumerator opening()
    {
        openandclose.Play("Opening");
        open = true;
        audiosource.PlayOneShot(openclip);
        yield return new WaitForSeconds(.5f);
    }

    IEnumerator closing()
    {
        openandclose.Play("Closing");
        open = false;
        audiosource.PlayOneShot(openclip);
        yield return new WaitForSeconds(.5f);
    }
}