using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator Anima;
    // Start is called before the first frame update
    void Start()
    {
        Anima = GetComponent<Animator>();
    }

    public void Animation( Vector2 Player)
    {
        Anima.ResetTrigger("WalkFlag");
        Anima.ResetTrigger("BackFlag");
        Anima.ResetTrigger("StandFlag");

        if (Player.x != 0 || Player.y != 0)
        {
            if(Player.y > 0)
            {
                Anima.SetTrigger("WalkFlag");
            }
            else if(Player.y < 0) 
            {
                Anima.SetTrigger("BackFlag");
            }
        }
        else
        {
            Anima.SetTrigger("StandFlag");
        }

        Debug.Log(Player.y);
    }
}
