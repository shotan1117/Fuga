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
    //private Rigidbody rb;
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
        //入力
        move.x = Input.GetAxisRaw("Horizontal") * speed;
        move.y = Input.GetAxisRaw("Vertical") * speed;  
        PlayerAnimator.Animation(move);
        WalkSound();

        if (characterController.isGrounded)
        {
            vSpeed = 0;
        }
        vSpeed -= gravity * Time.deltaTime;
        Vector3 moveVec = (transform.right * move.x) + (transform.forward * move.y) + new Vector3(0, vSpeed, 0);
        characterController.Move(moveVec);
    }

    private void FixedUpdate()
    {    
        //移動
        //rb.velocity = (transform.right * move.x) + (transform.forward * move.y) + new Vector3(0, rb.velocity.y, 0);
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
}
