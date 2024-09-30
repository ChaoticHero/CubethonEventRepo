using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VideoOpener : MonoBehaviour
{
    public UnityEvent video;
    // Start is called before the first frame update
    



    private void OnTriggerEnter(Collider other)
    {
        video.Invoke();
    }

    // Update is called once per frame
    

    public void open()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=SY_0hvvacKA");
    }

}
