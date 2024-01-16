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
    
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
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
        //入力
        PlayerInput();           
    }

    private void FixedUpdate()
    {    
        Vector3 moveVec = (transform.right * move.x * speed) + (transform.forward * move.y * speed) + new Vector3(0, vSpeed, 0);
        characterController.Move(moveVec);
    }    
    private void WalkSound()
    {
        //移動時のみサウンドを鳴らす
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
        if (Input.GetKey(InputManeger.Instance.Key[0]))
        {
            move.y = 1;
        }
        else if (Input.GetKey(InputManeger.Instance.Key[1]))
        {
            move.y = -1;
        }
        else if (Input.GetKey(InputManeger.Instance.Key[2]))
        {
            move.x = -1;
        }
        else if (Input.GetKey(InputManeger.Instance.Key[3]))
        {
            move.x = 1;
        }
        else
        {
            move = Vector2.zero;
        }
    }

    void Gravity()
    {
        if (characterController.isGrounded)
        {
            vSpeed = 0;
        }
        vSpeed -= gravity * Time.deltaTime;
    }
}
