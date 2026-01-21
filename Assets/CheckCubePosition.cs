using System.Diagnostics;
using UnityEngine;

public class CheckCubePosition : MonoBehaviour
{
    void Start()
    {
        // World Space position
        Vector3 worldPos = transform.position;

        // Local Space position (so với Parent)
        Vector3 localPos = transform.localPosition;

        Debug.Log("World Position of Cube: " + worldPos);
        Debug.Log("Local Position of Cube: " + localPos);
    }
}
