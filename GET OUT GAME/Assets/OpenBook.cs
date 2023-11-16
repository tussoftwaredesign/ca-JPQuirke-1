using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cover;
    public HingeJoint myHinge;
    void Start()
    {
        var myHinge = cover.GetComponent<HingeJoint>();
        myHinge.useMotor = false;
    }

    public void OpenSesame()
    {
        myHinge.useMotor = true;
        Debug.Log("motor should be true");
    }

}
