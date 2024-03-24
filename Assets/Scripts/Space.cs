using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    [Header("Data")]
    [SerializeField] private int cellNumber;
    [Header("Components")]
    [SerializeField] private GameManager gm;

    private void OnMouseDown() {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        gm.FillCell(cellNumber);
    }
}
