﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody>();
        var HingeJoint = GetComponent<HingeJoint>();
        HingeJoint.useSpring = false;
       
        //var hinge = GetComponent<HingeJoint>();

        //// Make the hinge motor rotate with 90 degrees per second and a strong force.
        //var motor = hinge.motor;
        //motor.force = 100;
        //motor.targetVelocity = 90;
        //motor.freeSpin = false;

        //hinge.useMotor = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
