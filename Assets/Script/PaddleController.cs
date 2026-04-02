using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;

    private float targetPressed;
    private float targetRelease;
    private HingeJoint hinge;

    private void Start()
    {
        hinge = GetComponent<HingeJoint>();

        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    private void Update()
    {
        ReadIput();
    }

    private void ReadIput()
    {
        JointSpring jointSpring = hinge.spring;
        if (Input.GetKey(input))
        {  
            jointSpring.targetPosition= targetPressed;
        }
        else
        {
             jointSpring.targetPosition = targetRelease;
        }

        hinge.spring = jointSpring;
    }
}
