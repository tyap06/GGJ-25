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

    //private string TOOL_TAG = "Tool";

    [SerializeField]
    private Tool tool1; // reference to tool

    public GameObject selectedObject;


    void Awake()
    {

        myBody = gameObject.GetComponent<Rigidbody2D>();
        myTransform = gameObject.GetComponent<Transform>();

    }

    void Start()
    {
        
    }

    void Update()
    {
        DestroyBubble();
        StartCoroutine(BubbleFloatUp()); 
    }

    // Make bubble float up wait few seconds then make it float up coroutine
    IEnumerator BubbleFloatUp()
    {
        yield return new WaitForSeconds(bubble_timer);
        // Move the object upward in world space 1 unit/second.
        transform.Translate(Vector3.up * Time.deltaTime/2, Space.World);
    }


    private void DestroyBubble()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (GetComponent<Collider>().Raycast(ray, out hitInfo, Mathf.Infinity))
        {
            if(Physics.Raycast(ray, out hitInfo))
            {
                if(Input.GetMouseButtonDown(0) && hitInfo.transform.CompareTag("Bubble clone"))
                {
                    Destroy(hitInfo.transform.gameObject);
                }
            }
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

}
