using UnityEngine;

public class Tool
{
    public int ammo; // 10 bullets
    public string type;
    public float timer;

    public Tool (int ammo, string type)
    {
        this.ammo = ammo;
        this.type = type;
        timer = 0.0f;
    }
}
