using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle : MonoBehaviour {


    public LayerMask ColMask;

    public float speed;
    public float rotSpeed;

    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 v = Vector3.Reflect(transform.up, collision.contacts[0].normal);
        float rot = 90 - Mathf.Atan2(v.z, v.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(90, rot, 0);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(transform.forward * speed * Time.deltaTime);

        //Ray ray = new Ray(transform.position, transform.forward);
        //RaycastHit hit;

        //if (Physics.Raycast(ray, out hit, Time.deltaTime * speed + 0.1f, ColMask))
        //{
        //    Vector3 ReflectDir = Vector3.Reflect(ray.direction, hit.normal);
        //    float rot =  Mathf.Atan2(ReflectDir.z, ReflectDir.x) * Mathf.Rad2Deg;
        //    transform.eulerAngles = new Vector3(0, rot, 0);
        //}

    }






    //   public float speed = 10f;
    //   private bool Reverse = false;

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //       transform.Translate(new Vector3(0f, 0f, 1f) * speed * Time.deltaTime, Space.Self);


    //   }

    //   private void OnCollisionEnter(Collision col)
    //   {
    //       if (col.gameObject.tag == "Player")
    //       {
    //           //speed *= -1;
    //       }

    //       if (col.gameObject.tag == "Wall")
    //       {
    //           // speed *= -1;
    //           transform.eulerAngles = new Vector3(transform.rotation.eulerAngles.x,
    //              (transform.rotation.eulerAngles.y * -1)
    //              , transform.rotation.eulerAngles.z);
    //       }
    //   }

}
