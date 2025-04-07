
using UnityEngine;
using UnityEngine.Playables;

public class ValuesLeftJoystick : MonoBehaviour
{
    public Vector2 distance;
    public Vector2 startPos;
    public Vector2 endPos;

    public float horizontal;
    public float vertical;
    bool isI = true;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        endPos = transform.position;

        distance = startPos - endPos;

        horizontal = -distance.normalized.x;
        vertical = -distance.normalized.y;

        if (endPos != startPos)
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
