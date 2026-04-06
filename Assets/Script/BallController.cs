using UnityEngine;

public class BallController : MonoBehaviour
{
    public float maxSpeed;

    private Rigidbody rig;
    
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rig.linearVelocity.magnitude > maxSpeed)
        {
            rig.linearVelocity = rig.linearVelocity.normalized * maxSpeed;
        }
    }
}
