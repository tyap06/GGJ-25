using UnityEngine;
using System.Collections.Generic;

public class Teacher : MonoBehaviour
{
    public int num_popped_bubbles; // how many bubbles user (teacher) has popped
    public List<Tool> tool_inventory = new List<Tool>();
    //public Tool pencil;
    
    /*
    public Teacher() {
        this.tool_inventory.Add(pencil);
        this.num_popped_bubbles = 0;

    }
    */


    //Teacher teacher;

    void Start()
    {
        //teacher = new Teacher();
        //pencil.ammo = 10;
       // pencil.type = "pencil";
        //pencil = Tool(10, "pencil");
        //tool_inventory.Add(pencil);
        num_popped_bubbles = 0;
        Info();

        /*
        GameObject gameObject = new GameObject("teacher");
        teacher = gameObject.AddComponent<Teacher>();
        teacher.Info();
        */
    }

    void Update()
    {

    }
    
    public void Info() {
        //Debug.Log(tool_inventory.Contains(pencil)); 
        Debug.Log("Popped Bubbles: " + num_popped_bubbles);
    }


    public void Attack ()
    {
        // is attacking == true? when mouse is clicked
    }


}
