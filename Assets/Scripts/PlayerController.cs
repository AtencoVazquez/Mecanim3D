using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Animator playerAnimator;
    private Rigidbody playerRB;

    private void Awake()
    {
        playerAnimator = GetComponent<Animator>();
        playerRB = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal");
        playerAnimator.SetFloat("ForwardSpeed", verticalAxis);
        playerAnimator.SetFloat("TurnSpeed", horizontalAxis);
        
    }
}
