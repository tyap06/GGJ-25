using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    Teacher teacher;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Teacher teacher = new Teacher();
        teacher.Info();
    }

    // Update is called once per frame
    /*void Update()
    {

    }
    */
}

