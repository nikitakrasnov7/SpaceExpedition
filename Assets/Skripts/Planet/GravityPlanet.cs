using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityPlanet : MonoBehaviour
{
    List<Rigidbody> rigidbodiesObjects = new List<Rigidbody>();

    Rigidbody rigidbodyPlanet;

    private void Start()
    {
        rigidbodyPlanet = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        foreach (var objectR in rigidbodiesObjects)
        {
            Vector3 dir = (transform.position - objectR.position).normalized;

            float distance = (transform.position - objectR.position).magnitude;
            float strenght = 500 * objectR.mass * rigidbodyPlanet.mass / (distance * distance);

            objectR.AddForce( dir * strenght);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
        {
            rigidbodiesObjects.Add(other.attachedRigidbody);
        }
    }
}
