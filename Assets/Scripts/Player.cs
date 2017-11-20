using System.Collections;
using UnityEngine.Networking;
using UnityEngine;

public class Player : NetworkBehaviour {

    private Camera cam;
    public bool Lock =  false;
    public float _knockaback;
    public Balle ball;
    protected float _Multiplicateur = 1.1f;
    public GameObject BallePref;
    public Transform SpawnPos;

    public virtual void Move(float speed)
    {
        if (!Lock)
        {
            float Xmove = Input.GetAxis("Horizontal");
            float Zmove = Input.GetAxis("Vertical");

            transform.position += (new Vector3(Xmove, 0f, Zmove) * speed * Time.deltaTime);
        }
       
    }

    
    public virtual void Effect()
    {

    }

    public void Power ()
    {
        if(Input.GetKeyDown("a"))
        {
            Effect();
        }
    }
    [Command]
    public void CmdInitiate()
    {
        if (GameObject.FindObjectOfType<Balle>() == null)
        {
            SpawnPos = GameObject.FindGameObjectWithTag("StartBall").transform;
            var _Ball = (GameObject)Instantiate(BallePref, SpawnPos.position, SpawnPos.rotation);
            NetworkServer.Spawn(_Ball);
        }
    }
	// Use this for initialization

	protected virtual void Start () {

        CmdInitiate();
       
       
        cam = GameObject.FindObjectOfType<Camera>();
        ball = GameObject.FindObjectOfType<Balle>();
        
    }
	
	// Update is called once per frame
	protected virtual void Update () {


        CmdInitiate();
        if (!Lock)
        {
            Vector3 mouse = Input.mousePosition;
            mouse = cam.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, 5f));

            transform.LookAt(new Vector3(mouse.x, transform.position.y, mouse.z));
        }

        Power();
        
            Block();
        
	}

    public void Block()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Lock = !Lock;
        }
    }

    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "ball")
        {
           
            Knockback();
            gameObject.GetComponent<Rigidbody>().AddForce(_knockaback * transform.forward);
            ball.speed = ball.speed*_Multiplicateur;
        }
    }

    protected void Knockback()
    {
       
        _knockaback = ball.speed * 30;
    }
}
