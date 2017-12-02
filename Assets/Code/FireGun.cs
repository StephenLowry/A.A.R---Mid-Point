using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour {

    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            anim.SetTrigger("Shoot");
        }
    }
}
