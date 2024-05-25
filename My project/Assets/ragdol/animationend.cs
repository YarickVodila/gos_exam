using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationend : MonoBehaviour
{
    public GameObject otherGameObject;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Animator component from the same GameObject the script is attached to
        animator = GetComponent<Animator>();

        if (animator == null)
        {
            // Just in case, check if Animator component is missing so you can handle the error
            Debug.LogError("Animator component not found on the object.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log(animator);
            animator.enabled = false;
        }
    }
}
