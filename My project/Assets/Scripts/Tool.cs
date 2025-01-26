using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    
    public int ammo; // 10 bullets
    public string type; // pencil,ruler, stamp
    public float timer;
    //public List<Tool> tool_inventory = new List<Tool>();
    public int max_ammo;
    public string tool_type;



    /*
    public int ammo; // 10 bullets
    public string type; // pencil,ruler, stamp
    public float timer;

    public Tool (int ammo, string type)
    {
        this.ammo = ammo;
        this.type = type;
        timer = 0.0f;
    }

    Tool tool;
    */

    void Start()
    {
        ammo = max_ammo;
        type = tool_type;

        
    }

    void Update()
    {
        Use_ammo();
        Reload_ammo();
    }

    // Decrement ammo everytime user uses mouse button right click
    void Use_ammo()
    {
        // check if user is pressing right mouse button
        if (Input.GetMouseButtonDown(0) == true && ammo > 0)
        {
            ammo--;
            Debug.Log("Current ammo: " + ammo);

        }
        
    }

    // Coroutine for reload timer
    IEnumerator Reload_timer()
    {
        yield return new WaitForSeconds(timer);
        //Debug.Log("reloading");
        ammo = max_ammo;
        Debug.Log("Ammo reloaded: " + ammo);
        
    }

    // Reload ammo when ammo = 0
    void Reload_ammo()
    {
        if(ammo == 0)
        {
            StartCoroutine(Reload_timer());
            Debug.Log("reloading");
            //ammo = max_ammo;
            //Debug.Log("Ammo reloaded: " + ammo);

        }
    }
}
