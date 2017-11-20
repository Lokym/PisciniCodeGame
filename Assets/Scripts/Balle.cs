using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle : MonoBehaviour {



    public GameObject Ball;
    public Transform StartPos;
    public float speed;
    public float rotSpeed;
    private float _yStart;
    public float Multiplicateur = 1.1f;
    private Score _score;

    // Use this for initialization
    void Start()
    {
        _yStart = transform.position.y;
        _score = GameObject.FindObjectOfType<Score>();
      
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Test");
        Vector3 v = Vector3.Reflect(transform.up, collision.contacts[0].normal);
        float rot = 90 - Mathf.Atan2(v.z, v.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(90, rot, 0);

        if (collision.gameObject.tag == "But")
        {
            _score.ChangeVal(1, 0);
            Destroy(gameObject);
            
           
        }

        if (collision.gameObject.tag == "LocalBut")
        {
            _score.ChangeVal(0,1);
         
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
      

        transform.Translate(transform.forward * speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, _yStart, transform.position.z);

        if(speed > 10f)
        {
            speed = 10f;
        }
      
    }

  


}
