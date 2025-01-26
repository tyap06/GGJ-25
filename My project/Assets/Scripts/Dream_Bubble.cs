using UnityEngine;

public class Dream_Bubble : MonoBehaviour
{
    public int Bubble_type;
    public bool is_popped;
    public float speed;

    public Dream_Bubble()
    {
        this.Bubble_type = 0;
        this.is_popped = false;
        this.speed = 2.0f;
    }
}
