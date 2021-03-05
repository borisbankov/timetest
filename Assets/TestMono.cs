using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestMono : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI _component;
    private void Awake()
    {
        Debug.Log("Awake");
        _component = GameObject.Find("TestText").GetComponent<TextMeshProUGUI>();

    }
    void Start()
    {
        Debug.Log("Start");    
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _component.enabled = !_component.enabled;
        }
        _component.text = "current time is +" + Time.deltaTime;
    }
}
