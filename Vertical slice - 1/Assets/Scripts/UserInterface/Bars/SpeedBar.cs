using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedBar : MonoBehaviour {

    private Image _image;
    private float _percentage = 100;

    void Awake()
    {
        _image = GetComponent<Image>();
    }


    void Update()
    {
        UpdateBar();
    }

    public void UpdateBar()
    {
        _image.fillAmount = _percentage;
    }

    public void SetPercentage(float value)
    {
        _percentage = value;
    }
}
