using UnityEngine;
using System.Collections;
using CnControls;

public class MovCat : MonoBehaviour {


    public Transform gato;
    public float test;
    private bool JumpControl = true;
    private bool JumpFlag = false;
    private int Dir;
    private Animator animator;
    private Rigidbody rb;
    // Use this for initialization
    void Start () {

        animator = this.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {

        float moveInput = CnInputManager.GetAxis("Horizontal") * Time.deltaTime * 3;

        Direction();
        Jump();

        transform.position += new Vector3(moveInput, 0, 0);

        if (CnInputManager.GetButtonDown("Jump") && JumpFlag)
        {
            
            rb.AddForce(new Vector3(0,340,0));

        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Piso")
        {
            JumpFlag = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Piso")
        {
            JumpFlag = false;
            if (!CnInputManager.GetButtonDown("Jump"))
            {


            }
        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Mariposa")
        {
            //print ("Works");
            Destroy(col.gameObject);
        }
    }
    void Direction()
    {
        if (CnInputManager.GetAxis("Horizontal") > 0)
        {
            Dir = 1;
            transform.localScale = new Vector3(Dir * 0.5f, 0.5f, 1);

        }
        if (CnInputManager.GetAxis("Horizontal") < 0)
        {
            Dir = -1;
            transform.localScale = new Vector3(Dir * 0.5f, 0.5f, 1);
        }
    }

    void Jump()
    {
        if (CnInputManager.GetButtonDown("Jump"))
        {

            StartCoroutine("JumpStop");
        }
    }

    IEnumerator JumpStop()
    {
        animator.SetInteger("Jump", 2);
        yield return new WaitForSeconds(1);

        animator.SetInteger("Jump", 0);
    }

    IEnumerator FallStop()
    {
        animator.SetInteger("Jump", 1);
        yield return new WaitForSeconds(0.5f);
        animator.SetInteger("Jump", 0);
    }


}

