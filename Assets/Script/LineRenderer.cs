using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderer : MonoBehaviour
{
    private LineRenderer line;
    private float counter;
    private float dist;

    public Transform origin;
    public Transform destino;


    public float lineDrawSpeed = 6f;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        

        dist = Vector3.Distance(origin.position, destino.position);
    }

    void Update()
    {
        counter += 0.1f / lineDrawSpeed;

        float x = Mathf.Lerp(0, dist, counter);

        Vector3 pointA = origin.position;
        Vector3 pointB = destino.position;

        Vector3 PointAlongLIne = x * Vector3.Normalize(pointB - pointA) + pointA;
    }



}
