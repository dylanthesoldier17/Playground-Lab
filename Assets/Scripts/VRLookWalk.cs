using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VRLookWalk : MonoBehaviour
{
    // VR Main Camera
    public Transform vrCamera;
    // Agol spored koj se realizira dvizenjeto na igracot
    public float toggleAngle = 30.0f;
    // Brzina so koja ke se dvizi igracot
    public float speed = 3.0f;
    // Promenliva koja ke regulira dali moze da se dvizi igracot ili ne 
    public bool moveForward;
    // CharacterController scripta
    public CharacterController cc;
    void Start()
    {
        //inicijalizacija na CharacterController
        cc = GetComponentInParent<CharacterController>();
    }
    void Update()
    {
        // dokolku gleda pomalku od 90 degree toa znaci gleda nadolu i moze da se dvizi
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            //Moze da se dvizi
            moveForward = true;
        }
        else
        {
            //Ne moze da se dvizi
            moveForward = false;
        }
        //Dokolku moze da se dvizi igracot
        if (moveForward)
        {
            //Se naoga nasokata na dvizenje 
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            //so ova se izveduva dvizenjeto/pomestuvanjeto
            cc.SimpleMove(forward * speed);
        }
    }
}


