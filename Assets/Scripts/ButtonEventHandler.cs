using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventHandler : MonoBehaviour
{

    private GameObject[] player;
    private bool buttonPressed;
    private VirtualButtonBehaviour vb;

    void Start() {

        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }

        player = GameObject.FindGameObjectsWithTag("Player");

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        buttonPressed = true;
        this.vb = vb;
        player[0].transform.Rotate(10.0f, 0.0f, 0.0f, Space.Self);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        buttonPressed = false;
        this.vb = vb;
    }

    public void Update()
    {

        Quaternion rotation = Quaternion.LookRotation(player[0].transform.forward, Vector3.up);
        Vector3 targetForward = rotation * Vector3.forward;

        if(vb != null)
        {
            switch (vb.VirtualButtonName)
            {
                case "up":
                    if (buttonPressed)
                    {
                        player[0].transform.position += targetForward * 0.03f;
                    }
                    break;
                case "left":
                    if (buttonPressed)
                    {
                        player[0].GetComponent<Player>().changeAngle(1);
                    }
                    break;
                case "right":
                    if (buttonPressed)
                    {
                        player[0].GetComponent<Player>().changeAngle(-1);
                    }
                    break;
                case "down":
                    if (buttonPressed)
                    {
                        player[0].transform.position -= targetForward * 0.03f;
                    }
                    break;
            }
        }
        
    }
}
