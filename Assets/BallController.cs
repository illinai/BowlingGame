using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;

    private Rigidbody ballRB;
    private bool isBallLaunched;

    void Start()
    {
        //Grabbing a reference to RigidBody
        ballRB = GetComponent<Rigidbody>();

        //Add a listener to the OnSpace event
        //On press LaunchBall method called
        inputManager.OnSpacePressed.AddListener(LaunchBall);
        
    }

    private void LaunchBall()
    {
        // check if ball is launched

        if (isBallLaunched) return;

        isBallLaunched = true;

        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
