using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerKill : MonoBehaviour {

    private Text _text;
    private RectTransform _rtrans;
    [SerializeField] private Vector2 _position;
    [Header("Time the killfeed will exist")]
    [SerializeField] private float _existTime;

    [Header("Opacity time & speed.")]
    [SerializeField] private float _opacityTime;

    private float _decaySpeed, _timer;
    [Header("Time to shift down when a new object spawns.")]
    [SerializeField] private float _shiftDownSpeed;
    [SerializeField] private float _shiftDownHeight;

    private float _shiftDownCounter;
    private bool _shiftDown;

    private bool _fadeout = false;

    public void Setup(string message)
    {
        _text = GetComponent<Text>();
        _rtrans = GetComponent<RectTransform>();

        _text.text = message;
        _rtrans.position = _position;

        _text.CrossFadeAlpha(0f, 0, false);
        _text.CrossFadeAlpha(1f, _opacityTime, false);
    }

    void Update()
    {
        _timer += Time.deltaTime;
        if(_timer > _existTime - (_opacityTime*3) && !_fadeout)
        {
            _text.CrossFadeAlpha(0f, _opacityTime, false);
            _fadeout = true;
        }

        if (_timer >= _existTime) Destroy(gameObject);

        if (_shiftDown) ShiftDown();
    }

    void ShiftDown()
    {
        Vector2 pos = _rtrans.position;

        if (_shiftDownCounter + _shiftDownSpeed >= _shiftDownHeight) 
        {
            pos.y -= _shiftDownHeight - _shiftDownCounter;
            _shiftDown = false;
            _shiftDownCounter = 0;
        }
        else
        {
            _shiftDownCounter += _shiftDownSpeed;
            pos.y -= _shiftDownSpeed;
        }
        _rtrans.position = pos;
    }

    public void ActivateShiftDown() { _shiftDown = true; }

}
