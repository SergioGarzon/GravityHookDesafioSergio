using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
/*    public GameObject hook;
    public GameObject hookHolder;


    public float hookTravelSpeed;
    public float playerTravelSpeed;

    public static bool fired;
    public static bool hocked;

    public GameObject hockedObject;

    public float maxDistance;

    private float currentDistance;

    public bool grounded;

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && fired == false)
        {
            fired = true;
        }

        if(fired)
        {
            LineRenderer rope = hook.GetComponent<LineRenderer>();
            rope.SetPosition(0, hookHolder.transform.position);
            rope.SetPosition(1, hook.transform.position);
        } 

        if(fired && !hocked)
        {
            hook.transform.Translate(Vector3.forward * Time.deltaTime * hookTravelSpeed);
            currentDistance = Vector3.Distance(transform.position, hook.transform.position);

            if(currentDistance >= maxDistance)
            {
                ReturnHook();
            }
        }

        if(hocked == true && fired == true)
        {

            hook.transform.parent = hockedObject.transform;
            transform.position = Vector3.MoveTowards(transform.position, hook.transform.position, Time.deltaTime * playerTravelSpeed);
            float distanceToHook = Vector3.Distance(transform.position, hook.transform.position);

            this.GetComponent<Rigidbody>().useGravity = false;

            if(distanceToHook < 1)
            {
                if(!grounded)
                {
                    this.transform.Translate(Vector3.forward * Time.deltaTime * 10f);
                    this.transform.Translate(Vector3.up * Time.deltaTime * 18f);
                }

                StartCoroutine("Climb");
            }
        } else
        { 
            hook.transform.parent = hockedObject.transform;

            this.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    IEnumerator Climb()
    {
        yield return new WaitForSeconds(0.1f);
        ReturnHook();
    }

    void ReturnHook()
    {
        hook.transform.rotation = hookHolder.transform.rotation;
        hook.transform.position = hookHolder.transform.position;
        fired = false;
        hocked = false;

        LineRenderer rope = hook.GetComponent<LineRenderer>();
        rope.SetVertexCount(0);
    }


    void CheckFGrounded()
    {
        RaycastHit hit;
        float distance = 1f;

        Vector3 dir = new Vector3(0, -1);

        if(Physics.Raycast(transform.position, dir, out hit, distance))
        {
            grounded = true;
        } else
        {
            grounded = false;
        }
    }



    */



}

