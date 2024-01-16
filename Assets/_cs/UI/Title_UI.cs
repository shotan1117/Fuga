using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title_UI : MonoBehaviour
{
    //�C���X�y�N�^�[����ݒ肷�邩�A����������GetComponent���āAText�ւ̎Q�Ƃ��擾���Ă����B
    [SerializeField]
    Text txt;

    //�ꃋ�[�v�̒���(�b��)�B
    [Header("1���[�v�̒���(�b�P��)")]
    [SerializeField]
    [Range(0.1f, 10.0f)]
    float duration = 1.0f;

    [Header("���[�v�J�n���̐F")]
    Color32 startColor = new Color32(99, 1,9, 255);

    [Header("���[�v�I�����̐F")]
    Color32 endColor = new Color32(99, 1, 9, 32);



    //�C���X�y�N�^�[����ݒ肵���ꍇ�́AGetComponent����K�v���Ȃ��Ȃ�ׁAAwake���폜���Ă��ǂ��B
    void Awake()
    {
        if (txt == null)
            txt = GetComponent<Text>();
    }

    void Update()
    {
        txt.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time / duration, 1.0f));
    }
}