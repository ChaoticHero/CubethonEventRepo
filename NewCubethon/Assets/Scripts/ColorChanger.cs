using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorChanger: MonoBehaviour
{
    public UnityEvent ColorChanged;
    public Material Material1;
    public Material Glow;
    public GameObject Object;
    Renderer rend;


    void Start()
    {
        rend = GetComponent<Renderer>();
        ColorChanged.AddListener(GameObject.Find("Obstacle").GetComponent<ObstacleColor>().Switch);
        ColorChanged.AddListener(GameObject.Find("Obstacle (4)").GetComponent<ObstacleColor>().Switch);
        ColorChanged.AddListener(GameObject.Find("Obstacle (1)").GetComponent<ObstacleColor>().Switch);
        ColorChanged.AddListener(GameObject.Find("Obstacle (5)").GetComponent<ObstacleColor>().Switch);
        ColorChanged.AddListener(GameObject.Find("Obstacle (11)").GetComponent<ObstacleColor>().Switch);
        ColorChanged.AddListener(GameObject.Find("Obstacle (2)").GetComponent<ObstacleColor>().Switch);
        ColorChanged.AddListener(GameObject.Find("Obstacle (6)").GetComponent<ObstacleColor>().Switch);
        ColorChanged.AddListener(GameObject.Find("Obstacle (3)").GetComponent<ObstacleColor>().Switch);
        ColorChanged.AddListener(GameObject.Find("Obstacle (7)").GetComponent<ObstacleColor>().Switch);
        ColorChanged.AddListener(GameObject.Find("Obstacle (12)").GetComponent<ObstacleColor>().Switch);
        ColorChanged.AddListener(GameObject.Find("Obstacle (8)").GetComponent<ObstacleColor>().Switch);
        ColorChanged.AddListener(GameObject.Find("Obstacle (9)").GetComponent<ObstacleColor>().Switch);
        ColorChanged.AddListener(GameObject.Find("Obstacle (10)").GetComponent<ObstacleColor>().Switch);



    }

    public void Switch()
    {
        rend.sharedMaterial = Glow;
    }
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.name == "Player")
        {
            ColorChanged.Invoke();
            Destroy(this.gameObject);
            Switch();
        }
    }

}