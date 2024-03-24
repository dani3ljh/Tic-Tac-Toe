using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private GameManager gm;

    void Start()
    {
        gm = GetComponent<GameManager>();
    }

    void Update()
    {
        if (Input.GetAxis("Reset") > 0) {
            gm.Reset();
        }
        if (Input.GetKeyDown(KeyCode.Keypad7)) {
            gm.FillCell(0);
        }
        if (Input.GetKeyDown(KeyCode.Keypad8)) {
            gm.FillCell(1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad9)) {
            gm.FillCell(2);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4)) {
            gm.FillCell(3);
        }
        if (Input.GetKeyDown(KeyCode.Keypad5)) {
            gm.FillCell(4);
        }
        if (Input.GetKeyDown(KeyCode.Keypad6)) {
            gm.FillCell(5);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1)) {
            gm.FillCell(6);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2)) {
            gm.FillCell(7);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3)) {
            gm.FillCell(8);
        }
    }
}
