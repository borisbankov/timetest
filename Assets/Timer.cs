using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class Timer : MonoBehaviour
{
    [SerializeField]
    private float _timeStart = 60;
    [SerializeField]
    private TextMeshProUGUI _textBox; 
    // Start is called before the first frame update
    void Start()
    {
        _textBox.text = _timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        _timeStart -= Time.deltaTime;
        _textBox.text = Mathf.Round(_timeStart).ToString();
    }
}
