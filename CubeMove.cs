using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    private int currentSpeed;
    private int currentDistance;

    void Start()
    {
        currentSpeed = CubeController.speedValue;
        currentDistance = CubeController.distanceValue;
    }
    void Update()
    {
        transform.position += Vector3.forward * currentSpeed * Time.deltaTime;

        if (transform.position.z >= currentDistance)
            Destroy(gameObject);
    }
}
