using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTest : MonoBehaviour
{
    public Animator animator;

    public KeyCode keyToTrigger = KeyCode.A;
    public KeyCode keyToExit = KeyCode.S;
    public string triggerToPlay = "Fly";

    private void OnValidate()
    {
        if (animator == null) animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(keyToTrigger))
        {
            //animator.SetTrigger(triggerToPlay);
            //animator.SetBool(triggerToPlay, true);

            animator.SetBool(triggerToPlay, !animator.GetBool(triggerToPlay));
        }

        /*else if (Input.GetKeyDown(keyToExit))
        {
            
            animator.SetBool(triggerToPlay, false);
        }*/
    }
}
