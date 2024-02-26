using UnityEngine;

public class HingeJointMotorControl : MonoBehaviour
{
    private HingeJoint2D hingeJoint;
    private float originalMotorSpeed;

    void Start()
    {
        hingeJoint = GetComponent<HingeJoint2D>();

        originalMotorSpeed = hingeJoint.motor.motorSpeed;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hingeJoint.motor = new JointMotor2D { motorSpeed = 800, maxMotorTorque = hingeJoint.motor.maxMotorTorque };
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            hingeJoint.motor = new JointMotor2D { motorSpeed = originalMotorSpeed, maxMotorTorque = hingeJoint.motor.maxMotorTorque };
        }
    }
}