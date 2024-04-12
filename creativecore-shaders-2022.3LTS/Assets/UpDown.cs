using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour


{
    public float amplitude;
    public float frequency;

    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
              initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      
        float y = amplitude * Mathf.Sin(Time.time * frequency * 2 * Mathf.PI);
        transform.position = initialPosition + new Vector3(0, y, 0);
    }
}
