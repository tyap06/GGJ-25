using UnityEngine;
using System.Collections.Generic;

public class Teacher
{
    public int num_popped_bubbles; // how many bubbles user (teacher) has popped
    public List<Tool> tool_inventory = new List<Tool>();
    public Tool pencil = new Tool(10, "pencil");
    

    public Teacher() {
        this.tool_inventory.Add(pencil);
        this.num_popped_bubbles = 0;

    }
    
    public void Info() {
        Debug.Log(tool_inventory.Contains(pencil)); 
        Debug.Log("Popped Bubbles: " + num_popped_bubbles);
    }


    public void Attack ()
    {
        // is attacking == true? when mouse is clicked
    }


}
