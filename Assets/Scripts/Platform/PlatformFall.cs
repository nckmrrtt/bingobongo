using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour {

    public float fallDelay = 10f;
    public float dissolveDelay = 5.3f;
    private Rigidbody2D rb;
    private Animator anim;

	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        Invoke("Dissolve", dissolveDelay);
        Invoke("Fall", fallDelay);
    }
	
	// Update is called once per frame
	void Update () {
    }

    void Dissolve()
    {
        anim.SetTrigger("Dissolve");
    }

    void Fall()
    {
        rb.isKinematic = false;
    }
}
