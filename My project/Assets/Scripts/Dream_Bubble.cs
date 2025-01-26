using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dream_Bubble : MonoBehaviour
{
    public int Bubble_type;
    //public bool is_popped;
    public float speed;

    private Rigidbody2D myBody;
    private Transform myTransform;

    private string TOOL_TAG = "Tool";

    public Tool tool; // reference to tool

    


    void Awake()
    {

        myBody = gameObject.GetComponent<Rigidbody2D>();
        myTransform = gameObject.GetComponent<Transform>();
        //speed = 1.0f;

    }

    void Start()
    {
        
    }

    void Update()
    {
        //myBody.linearVelocity = new Vector2(speed, myBody.linearVelocity.y);

       
    }

    // checks if bubble is popped on right button mouse click
    // => bubble is popped when the correct tool is used
    // AND ammo is > 0
    // AND cursor (mouse) position is on bubble
    bool is_popped()
    {
        // when user clicks right mouse button
        if (Input.GetMouseButtonDown(0) && tool.ammo > 0 && Input.mousePosition == myTransform.position)
        {
            // pop bubble (destroy bubble)
            return true;

        }
        return false;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(TOOL_TAG))
        {

        }
    }

    




   
    /*public Dream_Bubble()
    {
        this.Bubble_type = 0;
        this.is_popped = false;
        this.speed = 2.0f;
    }
    */

}
