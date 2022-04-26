using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerActions : MonoBehaviour
{
    public Vector3 movementVector;
    public Animator myAnim;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        movementVector = new Vector3(horizontal, vertical,0);
        if (horizontal < 0)
            this.transform.localScale = new Vector3(-1, 1, 1);
        else if (horizontal>0)
            this.transform.localScale = new Vector3(1, 1, 1);
        myAnim.SetFloat("speed", Mathf.Abs(horizontal));
        this.transform.position += movementVector * speed * Time.deltaTime;

        if (Input.GetButtonDown("Jump"))
        {
            myAnim.SetTrigger("jump");
        }
    }
}
