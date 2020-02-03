using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    int layer = 0;
    Rigidbody rigitbody;

    private void Start()
    {
        rigitbody = transform.GetComponent<Rigidbody>();
    }

    void Update()
    {
        changeLayer();
        changePosition();
    }

    void changeLayer()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            bool isSomething = Physics.Raycast(transform.position, Vector3.forward, 2f);

            if (!isSomething)
            {
                layer = 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            bool isSomething = Physics.Raycast(transform.position, Vector3.back, 2f);

            if (!isSomething)
            {
                layer = 0;
            }
        }

        float delta = (layer * 2f - 2f) - rigitbody.position.z;
        Vector3 velocity =rigitbody.velocity;
        velocity.z = delta * 3f;
        rigitbody.velocity = velocity;
    }

    void changePosition()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector3.forward;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = -Vector3.forward;
        }

        rigitbody.AddTorque(direction * 25f);
    }
}
