using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float playersiderotate;

    [SerializeField]
    AudioClip clip;
    Vector2 Rote;
    public PlayerAnimator PlayerAnimator;
    public GameObject cam;
    Quaternion cameraRot, characterRot;
    private Rigidbody rb;
    private AudioSource audioSource;
    private Vector2 move;

    //角度の制限用
    float minX = -90f, maxX = 50f;
    // Start is called before the first frame update
    void Start()
    {
        cameraRot = cam.transform.localRotation;
        characterRot = transform.localRotation;
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0) { return; }
        Rote.x = Input.GetAxis("Mouse X") * playersiderotate;
        //縦方向の視点変更は遅く
        Rote.y = Input.GetAxis("Mouse Y") * playersiderotate;

        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        cameraRot *= Quaternion.Euler(-Rote.y, 0, 0);
        characterRot *= Quaternion.Euler(0, Rote.x, 0);

        //Updateの中で作成した関数を呼ぶ
        cameraRot = ClampRotation(cameraRot);
        cam.transform.localRotation = cameraRot;
        transform.localRotation = characterRot;
        PlayerAnimator.Animation(move);
        WalkSound();
    }

    private void FixedUpdate()
    {    
        if(move.x ==0 && move.y ==0)
        {
            rb.velocity = Vector3.zero;
            return;
        }
        rb.velocity = ((transform.right * move.x) * speed) + ((transform.forward * move.y) * speed) + new Vector3(0, rb.velocity.y, 0);
    }

    //角度制限関数の作成
    private Quaternion ClampRotation(Quaternion q)
    {
        //q = x,y,z,w (x,y,zはベクトル（量と向き）：wはスカラー（座標とは無関係の量）)
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1f;

        float angleX = Mathf.Atan(q.x) * Mathf.Rad2Deg * 2f;

        angleX = Mathf.Clamp(angleX, minX, maxX);

        q.x = Mathf.Tan(angleX * Mathf.Deg2Rad * 0.5f);

        return q;
    }
    private void WalkSound()
    {
        //移動時のみサウンドを鳴らす
        if (rb.velocity.magnitude != 0)
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
