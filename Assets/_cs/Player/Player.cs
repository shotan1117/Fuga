using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float playersiderotate;

    Vector2 Rote;
    public PlayerAnimator PlayerAnimator;
    public GameObject cam;
    Quaternion cameraRot, characterRot;
    private Rigidbody rb;
    private Vector2 move;

    //�p�x�̐����p
    float minX = -90f, maxX = 50f;
    // Start is called before the first frame update
    void Start()
    {
        cameraRot = cam.transform.localRotation;
        characterRot = transform.localRotation;
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0) { return; }
        Rote.x = Input.GetAxis("Mouse X") * playersiderotate;
        //�c�����̎��_�ύX�͒x��
        Rote.y = Input.GetAxis("Mouse Y") * playersiderotate;

        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        cameraRot *= Quaternion.Euler(-Rote.y, 0, 0);
        characterRot *= Quaternion.Euler(0, Rote.x, 0);

        //Update�̒��ō쐬�����֐����Ă�
        cameraRot = ClampRotation(cameraRot);
        cam.transform.localRotation = cameraRot;
        transform.localRotation = characterRot;
        PlayerAnimator.Animation(move);       
    }

    private void FixedUpdate()
    {    
        if(move.x ==0 && move.y ==0)
        {
            rb.velocity = Vector3.zero;
            return;
        }
        rb.velocity = ((transform.right * move.x) * speed) + ((transform.forward * move.y) * speed) + new Vector3(0, rb.velocity.y, 0) ;
    }

    //�p�x�����֐��̍쐬
    private Quaternion ClampRotation(Quaternion q)
    {
        //q = x,y,z,w (x,y,z�̓x�N�g���i�ʂƌ����j�Fw�̓X�J���[�i���W�Ƃ͖��֌W�̗ʁj)
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1f;

        float angleX = Mathf.Atan(q.x) * Mathf.Rad2Deg * 2f;

        angleX = Mathf.Clamp(angleX, minX, maxX);

        q.x = Mathf.Tan(angleX * Mathf.Deg2Rad * 0.5f);

        return q;
    }
    
}
