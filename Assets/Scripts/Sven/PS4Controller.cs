using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PS4Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Gamepad.all.Count; i++)
        {
            Debug.Log(Gamepad.all[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
