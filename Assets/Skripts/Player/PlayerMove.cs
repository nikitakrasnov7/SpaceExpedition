
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public ValuesLeftJoystick LeftJoystick;
    public ValuesRightJoystick RightJoystick;
    private Rigidbody rb;

    public Transform planetTranform;


    public PlayerController controller;

    public float Ox;
    public float fuel;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 global;
        if (Vector3.Distance(transform.position, planetTranform.position) < 280)
        {
            global = new Vector3(LeftJoystick.horizontal, RightJoystick.UpDown, LeftJoystick.vertical);
        }
        else
        {
            global = new Vector3(LeftJoystick.horizontal, 0, LeftJoystick.vertical);

        }
        Vector3 local = transform.TransformDirection(global);


        rb.velocity = local * 10;

        transform.Rotate(transform.up, RightJoystick.Rotate);

        Quaternion rotation = Quaternion.FromToRotation(-transform.up, planetTranform.position - transform.position);
        transform.rotation = rotation * transform.rotation;

    }
}
