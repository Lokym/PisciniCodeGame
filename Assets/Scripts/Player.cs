using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Camera cam;

    public virtual void Move(float speed)
    {
        float Xmove = Input.GetAxis("Horizontal");
        float Zmove = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(Xmove, 0f, Zmove) * speed * Time.deltaTime);
    }


	// Use this for initialization
	void Start () {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 mouse = Input.mousePosition;
        mouse = cam.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, 5f));

        Move(5f);

        transform.LookAt(mouse);
	}
}
