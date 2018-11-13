using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public float Speed = 10f;

    private Animator animator;

    // Use this for initialization
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Horizontal") * Speed;

        translation *= Time.deltaTime;

        if (translation > 0) {
            animator.Play("person_walk");
        }

        if(translation < 0) {
            animator.Play("person_walk_back");
        }

        transform.Translate(translation, 0, 0);
    }
}
