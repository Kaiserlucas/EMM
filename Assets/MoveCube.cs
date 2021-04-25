using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    private bool _isMovingForward;

    [SerializeField]
    private float speed = 1f;

    [SerializeField]
    private GameObject _myTarget;
    // Start is called before the first frame update
    void Start()
    {
        _isMovingForward = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.z >= 10)
        {
            _isMovingForward = false;
        } else if(transform.position.z <= -5)
        {
            _isMovingForward = true;
        }
        if( _isMovingForward )
        {
            transform.position += new Vector3(0, 0, 1) * Time.deltaTime * speed;
        } else
        {
            transform.position -= new Vector3(0, 0, 1) * Time.deltaTime * speed;
        }

        float randomValue = UnityEngine.Random.Range(-10f, 10f);
        transform.rotation *= Quaternion.Euler(0, 0, randomValue);
        _myTarget.transform.position = transform.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        _isMovingForward = !_isMovingForward;
    }
}
