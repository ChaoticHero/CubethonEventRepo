using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleColor : MonoBehaviour
{
    public Material Material1;
    public Material Glow;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    public void Switch()
    {
        rend.sharedMaterial = Glow;
    }
}
