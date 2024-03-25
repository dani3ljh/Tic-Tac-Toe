using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Cell[] cells;

    [HideInInspector]
    public bool isXTurn;

    [SerializeField] private Animator turnDisplay;

    private void Start() {
        isXTurn = true;
    }

    public void Reset() {
        for (int i = 0; i < cells.Length; i++) {
            cells[i].Reset();
        }
        isXTurn = true;
        turnDisplay.SetTrigger("XTurn");
    }

    public void FillCell(int num) {
        if (!cells[num].Fill(isXTurn))
            return;
        isXTurn = !isXTurn;
        turnDisplay.SetTrigger(isXTurn ? "XTurn" : "OTurn");
        if (
            CheckRow(num, !isXTurn) ||
            CheckCol(num, !isXTurn) || 
            num % 2 == 0 && CheckDiagonals(!isXTurn) // && happens before ||
        )
            Reset();
    }

    private bool CheckRow(int num, bool isX) {
        int left = num - num % 3;
        int middle = num - num % 3 + 1;
        int right = num - num % 3 + 2;

        if (cells[left].isX != isX || !cells[left].isFilled)
            return false;
        if (cells[middle].isX != isX || !cells[middle].isFilled)
            return false;
        if (cells[right].isX != isX || !cells[right].isFilled)
            return false;

        return true;
    }

    private bool CheckCol(int num, bool isX) {
        int top = num % 3;
        int middle = num % 3 + 3;
        int bottom = num % 3 + 6;

        if (cells[top].isX != isX || !cells[top].isFilled)
            return false;
        if (cells[middle].isX != isX || !cells[middle].isFilled)
            return false;
        if (cells[bottom].isX != isX || !cells[bottom].isFilled)
            return false;
        
        return true;
    }

    private bool CheckDiagonals(bool isX) {
        return CheckNegativeDiagonal(isX) || CheckPositiveDiagonal(isX);
    }

    private bool CheckPositiveDiagonal(bool isX) {
        int bottomLeft = 6;
        int middle = 4;
        int topRight = 2;

        if (cells[bottomLeft].isX != isX || !cells[bottomLeft].isFilled)
            return false;
        if (cells[middle].isX != isX || !cells[middle].isFilled)
            return false;
        if (cells[topRight].isX != isX || !cells[topRight].isFilled)
            return false;
        
        return true;
    }

    private bool CheckNegativeDiagonal(bool isX) {
        int topLeft = 0;
        int middle = 4;
        int bottomRight = 8;

        if (cells[topLeft].isX != isX || !cells[topLeft].isFilled)
            return false;
        if (cells[middle].isX != isX || !cells[middle].isFilled)
            return false;
        if (cells[bottomRight].isX != isX || !cells[bottomRight].isFilled)
            return false;
        
        return true;
    }
}
