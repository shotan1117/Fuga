using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float playersiderotate;

    public PlayerAnimator PlayerAnimator;
    public GameObject cam;
    Quaternion cameraRot, characterRot;
    private Rigidbody rb;
    private Vector2 move;

    //変数の宣言(角度の制限用)
    float minX = -90f, maxX = 50f;

    public PlayerAcsion PlayerAcsion;
     
    // Start is called before the first frame update
    void Start()
    {
        cameraRot = cam.transform.localRotation;
        characterRot = transform.localRotation;
        rb = GetComponent<Rigidbody>();
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float xRot = Input.GetAxis("Mouse X") * playersiderotate;
        //縦方向の視点変更は遅く
        float yRot = Input.GetAxis("Mouse Y") * playersiderotate;
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        cameraRot *= Quaternion.Euler(-yRot, 0, 0);
        characterRot *= Quaternion.Euler(0, xRot, 0);

        //Updateの中で作成した関数を呼ぶ
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
    
}
