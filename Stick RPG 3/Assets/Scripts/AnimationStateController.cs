using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    private Animator animator;

    bool isIdle;
    bool isWalking;
    bool isRunnig;
    bool isAiming;
    bool isShooting;
    bool isPunching;
    bool isPunching2;
    bool isBlocking;
    bool isReloading;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if(input != Vector3.zero){
            //animator.
            //Is walking
        }else if(input != Vector3.zero&& Input.GetKeyDown(KeyCode.LeftShift)){
            //Is running
        }else if(Input.GetKeyDown(KeyCode.Mouse2)){
            //Block
        }else if(Input.GetKeyDown(KeyCode.Mouse0)){
            //Punch1
        }
        
    }
}
