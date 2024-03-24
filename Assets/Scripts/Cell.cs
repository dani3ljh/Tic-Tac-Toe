using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [HideInInspector]
    public bool isFilled;
    [HideInInspector]
    public bool isX;

    [Header("Game Objects")]
    [SerializeField] private GameObject X;
    [SerializeField] private GameObject O;
    
    private void Start() {
        Reset();
    }

    public bool Fill(bool setX) {
        if (isFilled) 
            return false;

        isFilled = true;
        isX = setX;
        X.SetActive(setX);
        O.SetActive(!setX);

        return true;
    }

    public void Reset() {
        isFilled = false;
        isX = false;
        X.SetActive(false);
        O.SetActive(false);
    }
}
