using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float angle = 0;
    // Update is called once per frame
    void Update()
    {
        //Move Player
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        angle += moveHorizontal * 100 * Time.deltaTime;
        float angleRad = angle * Mathf.Deg2Rad;

        Vector3 targetDirection = new Vector3(Mathf.Sin(angleRad), 0, Mathf.Cos(angleRad));
        Quaternion rotation = Quaternion.LookRotation(targetDirection);

        Vector3 targetForward = rotation * Vector3.forward;

        Debug.Log(targetForward);
        Debug.Log(angle);

        transform.position += targetForward * moveVertical / 80;

        //Rotate Player
        
        transform.rotation = Quaternion.Euler(0, angle , 0);
    }
}
