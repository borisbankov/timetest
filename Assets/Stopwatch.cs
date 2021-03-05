using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Stopwatch : MonoBehaviour
{
    [SerializeField]
    private float _timeStart = 0;
    [SerializeField]
    private TextMeshProUGUI _textBox;

    bool _timerActive = false;

    private TextMeshProUGUI _buttonText;

    // Start is called before the first frame update
    void Start()
    {
        _textBox.text = _timeStart.ToString("F2");
        _buttonText = GameObject.Find("Stopwatch Button").GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timerActive)
        {
            _timeStart += Time.deltaTime;
            _textBox.text = _timeStart.ToString("F2");
        }
    }

    public void timerButton()
    {
        _buttonText.text = _timerActive ? "Start" : "Pause";
        _timerActive = !_timerActive;

    }
}
