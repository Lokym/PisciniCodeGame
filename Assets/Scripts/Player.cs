using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Camera cam;

    public virtual void Move(float speed)
    {

        
        float Xmove = Input.GetAxis("Horizontal");
        float Zmove = Input.GetAxis("Vertical");

        transform.position += (new Vector3(Xmove, 0f, Zmove) * speed * Time.deltaTime);
    }

    public virtual void Power ()
    {

    }

	// Use this for initialization
	void Start () {
        cam = GameObject.FindObjectOfType<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 mouse = Input.mousePosition;
        mouse = cam.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, 5f));

        

        transform.LookAt(new Vector3(mouse.x, transform.position.y, mouse.z));
	}


}
