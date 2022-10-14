using System.Collections;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public static int speedValue;
    public static int timeValue;
    public static int distanceValue;
    private bool spawnStarted = false;
    public GameObject cube;

    void Update()
    {
        if (speedValue > 0 && timeValue > 0 && distanceValue > 0 && !spawnStarted)
        {
            spawnStarted = true;
            StartCoroutine(Spawn(cube, timeValue));
        }
    }

    IEnumerator Spawn(GameObject cubeToSpawn, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        Instantiate(cubeToSpawn, this.transform.position, Quaternion.identity);
        spawnStarted = false;
    }
}
