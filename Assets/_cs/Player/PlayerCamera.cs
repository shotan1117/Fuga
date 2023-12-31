using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField]
    private float playersiderotate;

    public GameObject cam;
    Vector2 Rote;
    //角度の制限
    Quaternion cameraRot, characterRot;
    float minX = -90f, maxX = 65f;
    // Start is called before the first frame update
    void Start()
    {
        cameraRot = cam.transform.localRotation;
        characterRot = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        //入力
        Rote.x = Input.GetAxis("Mouse X") * playersiderotate;
        Rote.y = Input.GetAxis("Mouse Y") * playersiderotate;

        cameraRot *= Quaternion.Euler(-Rote.y, 0, 0);
        characterRot *= Quaternion.Euler(0, Rote.x, 0);

        cameraRot = ClampRotation(cameraRot);
        
    }
    private void FixedUpdate()
    {
        cam.transform.localRotation = cameraRot;
        transform.localRotation = characterRot;
    }
    private Quaternion ClampRotation(Quaternion c)
    {
        c.x /= c.w;
        c.y /= c.w;
        c.z /= c.w;
        c.w = 1f;

        float angleX = Mathf.Atan(c.x) * Mathf.Rad2Deg * 2f;

        angleX = Mathf.Clamp(angleX, minX, maxX);

        c.x = Mathf.Tan(angleX * Mathf.Deg2Rad * 0.5f);

        return c;
    }
}
