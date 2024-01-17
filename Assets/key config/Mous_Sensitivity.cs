using UnityEngine;
using UnityEngine.UI;

public class Mous_Sensitivity : MonoBehaviour
{
    public Slider Slider;
    public Text text;
    [SerializeField]
   private float Max_Sensitivity = 10.0f;

   private float Min_Sensitivity = 1.0f;


    void Start()
    {
        Slider.maxValue = Max_Sensitivity;
        Slider.minValue = Min_Sensitivity;
        Slider.value = InputManeger.Instance.MouseSensi;
        text.text = Slider.value.ToString("N2");
    }

    public void InputSensitivity()
    {
        text.text = Slider.value.ToString("N2");
        InputManeger.Instance.MouseSensi = Slider.value;
    }
}
