using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform target;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, -0.5f, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offsetRotated = target.rotation * offset;
        transform.rotation = target.rotation;
        transform.position = target.transform.position - offsetRotated;
    }
}
