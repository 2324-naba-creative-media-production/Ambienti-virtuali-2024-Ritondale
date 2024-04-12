using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float amplitude = 0.005f;
    public float frequency = 1f; 

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 newPosition = startPos + Vector3.up * Mathf.Sin(Time.time * frequency) * amplitude;

        transform.position = newPosition;

}
}