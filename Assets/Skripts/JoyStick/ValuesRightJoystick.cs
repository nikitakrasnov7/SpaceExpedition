using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValuesRightJoystick : MonoBehaviour
{
    private Vector2 distance;
    private Vector2 startPosition;
    private Vector2 endPosition;

    public float Rotate;
    public float UpDown;

    bool isI = true;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        endPosition = transform.position;

        distance = endPosition - startPosition;

        Rotate = distance.normalized.x;
        UpDown = distance.normalized.y;

        if (UpDown != 0)
        {

            if (isI)
            {
                isI = false;
                PlayerController.Instance.AddI();
            }
            PlayerController.Instance.isOxygen = true;
            PlayerController.Instance.StartOxygenDecrease();
        }
        else
        {
            if (!isI) 
            {
                isI = true;
                PlayerController.Instance.DicrI();
            }
            PlayerController.Instance.isOxygen = false;
        }


    }
}
