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
        transform.position += targetDirection * moveVertical / 40;

        //Rotate Player
        Quaternion rotation = Quaternion.LookRotation(targetDirection);
        transform.localRotation = rotation;
    }

    public void changeAngle(float angle)
    {
        this.angle += angle;
    }

}
