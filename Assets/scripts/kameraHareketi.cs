using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraHareketi : MonoBehaviour
{
    [SerializeField]
    private Transform top;
    [SerializeField]
    private Vector3 offset;
    [SerializeField]
    private float smoothSpeed;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - top.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = Vector3.Lerp(transform.position, offset + top.position, smoothSpeed); //Lineary interpolates between two points
        transform.position = newPosition;
    }
}
