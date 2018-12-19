using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour {

    private Image _image;
    [SerializeField]
    private Text _text;

    [SerializeField]
    private float _percentage = 100;
    private float _currentPercentage = 100;

    [SerializeField]
    private float _fallOffSpeed; // bar falloff speed

    private bool _fallOff = false;


    void Awake()
    {
        _image = GetComponent<Image>();
    }


    void Update()
    {
        if (_currentPercentage < _percentage) _currentPercentage = _percentage;
        if (_currentPercentage > _percentage && !_fallOff) EnableFallOff();

        FalloffUpdater();

        UpdateBar();
        UpdateText();
    }

    public void FalloffUpdater()
    {
        if (_fallOff)
        {
            _currentPercentage -= _fallOffSpeed;
            if (_currentPercentage <= _percentage) _fallOff = false;
        }
    }

    public void SetCurrent(float value)
    {
        _percentage = value;
    }

    public void EnableFallOff()
    {
        _fallOff = true;
    }

    public void UpdateBar()
    {
        _image.fillAmount = _currentPercentage / 100;
    }

    public void UpdateText()
    {
        _text.text = Mathf.Floor(_currentPercentage).ToString();
    }
}
