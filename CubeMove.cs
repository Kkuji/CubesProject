using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    private float startPositionZ;
    private float currentSpeed;
    private float currentDistance;

    void Start()
    {
        startPositionZ = this.transform.position.z;
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
