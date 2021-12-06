using System;
using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using UnityEngine;

public class VelociAgent : Agent
{
    public float SmallJumpAmount = 1.0f;
    private Rigidbody rb;

    private bool canJump = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    public override void OnEpisodeBegin()
    {
        base.OnEpisodeBegin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        var actionsOutDiscrete = actionsOut.DiscreteActions;
        if (Input.GetKey(KeyCode.Space))
            actionsOutDiscrete[0] = 1;
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        var actionsDiscrete = actions.DiscreteActions;
        if (actionsDiscrete[0] == 1)
        {
            Debug.Log("Small jump");
            SmallJump();   
        }
    }

    private void SmallJump()
    {
        if (canJump)
        {
            canJump = false;
            rb.AddForce(Vector2.up * SmallJumpAmount, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane"))
            canJump = true;
    }
}
