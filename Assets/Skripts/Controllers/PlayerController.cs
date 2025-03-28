using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int Formard;
    public int Left;
    public int Up;
    public int Rotate;


    private static PlayerController instance;
    public static PlayerController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindAnyObjectByType<PlayerController>();
            }
            return instance;
        }
    }

    private void Start()
    {
        ResetVector();
    }

    private void ResetVector()
    {
        Formard = 0;
        Left = 0;
        Up = 0;
        Rotate = 0;
    }


}
