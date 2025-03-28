
using UnityEngine;
using UnityEngine.EventSystems;


public class JoyStickMove : MonoBehaviour
{

    Vector3 startPosition;

    Touch[] touches;
    private void Start()
    {
        startPosition = transform.position;
    }

    public void Move()
    {
        touches = Input.touches;

        foreach (Touch touch in touches)
        {
            if (Vector2.Distance(touch.position, startPosition) < 400)
            {
                gameObject.transform.position = touch.position;
                gameObject.transform.position = startPosition + Vector3.ClampMagnitude(transform.position - startPosition, 250f);
            }

        }

    }
    public void ExitMove()
    {
        gameObject.transform.position = startPosition;
    }

}
