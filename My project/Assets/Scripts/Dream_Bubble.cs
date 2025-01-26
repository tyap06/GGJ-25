using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dream_Bubble : MonoBehaviour
{
    public int Bubble_type;
    //public bool is_popped;
    public float speed;
    public float bubble_timer;

    private Rigidbody2D myBody;
    private Transform myTransform;

    private string TOOL_TAG = "Tool";

    [SerializeField]
    private Tool tool1; // reference to tool

    private Camera mainCamera;

    public GameObject selectedObject;

    


    void Awake()
    {

        myBody = gameObject.GetComponent<Rigidbody2D>();
        myTransform = gameObject.GetComponent<Transform>();
        //speed = 1.0f;
        mainCamera = Camera.main;

    }

    void Start()
    {
        
    }

    void Update()
    {
        /*if(selectedObject == null)
        {
            return;
        }
        */
        //myBody.linearVelocity = new Vector2(speed, myBody.linearVelocity.y);
        //is_popped(tool1);
        SelectObject();
        //destroySelectedObject();
        StartCoroutine(BubbleFloatUp());
        


       
    }

    // Make bubble float up wait few seconds then make it float up coroutine
    IEnumerator BubbleFloatUp()
    {
        yield return new WaitForSeconds(bubble_timer);
        // Move the object upward in world space 1 unit/second.
        transform.Translate(Vector3.up * Time.deltaTime/2, Space.World);
    }

    private void SelectObject()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hitData = Physics2D.Raycast(new Vector2(worldPosition.x, worldPosition.y), Vector2.zero, 0);
        //if (hitData && Input.GetMouseButtonDown(0) && hitData.transform.CompareTag("Bubble clone"))
            if (hitData && Input.GetMouseButtonDown(0))
            {
            Destroy(hitData.collider.gameObject);

            selectedObject = hitData.transform.gameObject;
            Debug.Log("Hit Object 2D!");
            //Destroy(selectedObject);
            
        }
    }

    // destorys selected object otherwise do nothing
    private void destroySelectedObject()
    {
        if (selectedObject != null)
        {
            Destroy(selectedObject);
        }else
        {
            return;
        }

    }

    // checks if bubble is popped on right button mouse click
    // => bubble is popped when the correct tool is used
    // AND ammo is > 0
    // AND cursor (mouse) position is on bubble
    bool is_popped(Tool tool)
    {
        // when user clicks right mouse button
        if (Input.GetMouseButtonDown(0) && tool.ammo > 0 && Input.mousePosition == myTransform.position)
        {
            // pop bubble (destroy bubble)
            Debug.Log("Bubble popped!");
            Destroy(gameObject);

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
