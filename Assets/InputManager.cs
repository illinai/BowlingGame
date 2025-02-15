using System;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent OnSpacePressed = new UnityEvent();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*void Start()
    {
        
    }

    // Update is called once per frame
    */
}
