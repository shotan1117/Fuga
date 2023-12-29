using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    AudioClip clip;

    public PlayerAnimator PlayerAnimator;
    private Rigidbody rb;
    private AudioSource audioSource;
    private Vector2 move;

    
    // Start is called before the first frame update
    void Start()
    {     
       rb = GetComponent<Rigidbody>();
       audioSource = GetComponent<AudioSource>();
       Cursor.lockState = CursorLockMode.Locked;
       Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        //“ü—Í
        move.x = Input.GetAxisRaw("Horizontal") * speed;
        move.y = Input.GetAxisRaw("Vertical") * speed;  
        PlayerAnimator.Animation(move);
        WalkSound();
    }

    private void FixedUpdate()
    {    
        //ˆÚ“®
        rb.velocity = (transform.right * move.x) + (transform.forward * move.y) + new Vector3(0, rb.velocity.y, 0);
    }    
    private void WalkSound()
    {
        //ˆÚ“®Žž‚Ì‚ÝƒTƒEƒ“ƒh‚ð–Â‚ç‚·
        if (move.x != 0 || move.y != 0 && Time.timeScale == 1)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(clip);
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
