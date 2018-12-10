using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    [SerializeField]
    private GameObject _imageTimer;
    [SerializeField]
    private GameObject _textTimer;

    private Image _image;
    private Text _text;

    [SerializeField]
    private float _maximumTime,
                  _currentTime;


    void Awake()
    {
        _image = _imageTimer.GetComponent<Image>();
        _text = _textTimer.GetComponent<Text>();
        _maximumTime *= 60;
        _currentTime *= 60;
    }
	
    // Update time & image fill amount.
	void Update () {
        _currentTime -= Time.deltaTime;
        if (_currentTime < 0) _currentTime = 0;

        UpdateImage();
        UpdateText();
	}

    void UpdateImage()
    {
        _image.fillAmount = (_currentTime / _maximumTime);
    }

    void UpdateText()
    {
        string minutes, seconds;
        float tempMinutes, tempSeconds;

        tempMinutes = Mathf.Floor(_currentTime / 60);
        if (tempMinutes < 10) minutes = "0" + tempMinutes.ToString();
        else minutes = tempMinutes.ToString();

        tempSeconds = Mathf.Floor((((_currentTime/60)-tempMinutes)*100)*.6f);
        seconds = tempSeconds.ToString();

        _text.text = minutes + ":" + seconds;
    }
}
