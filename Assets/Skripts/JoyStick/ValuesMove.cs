using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValuesMove : MonoBehaviour
{
    PlayerController controller;

    private void Start()
    {
        controller = PlayerController.Instance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Forward":  controller.Formard = 1;break;

            case "Backward": controller.Formard = -1; break;

            case "Left": controller.Left = 1; break;

            case "Right": controller.Left = -1; break;

            case "Up": controller.Up = 1; break;

            case "Down": controller.Up= -1; break;

            case "RotateLeft": controller.Rotate = 1; break;

            case "RotateRight":controller.Rotate = -1; break;

             


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Forward": controller.Formard = 0; break;

            case "Backward": controller.Formard = 0; break;

            case "Left": controller.Left = 0; break;

            case "Right": controller.Left = 0; break;

            case "Up": controller.Up = 0; break;

            case "Down": controller.Up = 0; break;

            case "RotateLeft": controller.Rotate = 0; break;

            case "RotateRight": controller.Rotate = 0; break;

        }
    }
}
