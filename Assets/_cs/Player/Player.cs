using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    AudioClip Walkclip;
   
    public PlayerAnimator PlayerAnimator;

    private AudioSource audioSource;
    private Vector2 move;

    CharacterController characterController;
    float gravity = 9.8f;
    float vSpeed = 0; // 直近の重力
    
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
       Cursor.lockState = CursorLockMode.Locked;
       Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {   
        PlayerAnimator.Animation(move);
        WalkSound();
        Gravity();
        PlayerInput();           
    }

    private void FixedUpdate()
    {    
        Vector3 moveVec = (transform.right * move.x * speed) + (transform.forward * move.y * speed) + new Vector3(0, vSpeed, 0);
        characterController.Move(moveVec);
    }    
    private void WalkSound()
    {
        //移動時のサウンド
        if (move.x != 0 || move.y != 0 && Time.timeScale == 1)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(Walkclip);
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }

    public void PlayerInput()
    {
        //入力
        move.x =InputManeger.Instance.MoveX(move.x);
        move.y =  InputManeger.Instance.MoveY(move.y);
    }

    void Gravity()
    {
        //重力
        if (characterController.isGrounded)
        {
            vSpeed = 0;
        }
        vSpeed -= gravity * Time.deltaTime;
    }
}
