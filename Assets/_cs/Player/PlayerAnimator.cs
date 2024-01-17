using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Animator Anima;

    public void Animation( Vector2 Playermove)
    {
        Vector3 vec = Playermove.normalized;
        Anima.SetFloat("X" , vec.x);
        Anima.SetFloat ("Y" , vec.y);
    }
}
