using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    private Animator animator;

    bool isIdle;
    bool isWalking;
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
        // walk & run
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        bool isMoving = (input != Vector3.zero);
        bool isAnimatingWalk = animator.GetBool("IsWalking");
        bool isRunning = Input.GetKey("left shift");
        
        // aim & shoot

        // fight & block


        if(!isAnimatingWalk && isMoving){//start walking
            animator.SetBool("IsWalking", true);
        }else if (!isMoving){//stop walking
            animator.SetBool("IsWalking", false);
        }else if(isMoving && isRunning){//start running
            animator.SetBool("IsRunning", true);
        }else if(!isMoving || !isRunning){//stop running
            animator.SetBool("IsRunning", false); 
        }else if(Input.GetKey(KeyCode.Mouse2)){//start
            animator.SetBool("IsBlocking", true);
        }else if(Input.GetKeyUp(KeyCode.Mouse2)){
            animator.SetBool("IsBlocking", false);
        }else if(Input.GetKeyDown(KeyCode.Mouse0)){
            animator.SetBool("IsPunching1", true);
        }
        
    }
}
