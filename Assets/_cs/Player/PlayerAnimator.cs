using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Animator Anima;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Animation( Vector2 Playermove)
    {
        Anima.SetFloat("X" ,Playermove.x);
        Anima.SetFloat ("Y" ,Playermove.y);
    }
}
