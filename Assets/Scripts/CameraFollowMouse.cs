using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void Update()
    {
        float horizontalSpeed = 1f;
        float verticalSpeed = 1f;

        if (Input.GetButton("Fire2"))
        {
            float h = horizontalSpeed * Input.GetAxis("Mouse Y");
            float v = verticalSpeed * Input.GetAxis("Mouse X");
            transform.Translate(v, h, 0);
        }

    }
}
