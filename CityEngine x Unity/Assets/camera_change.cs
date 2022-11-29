using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_change : MonoBehaviour
{
    public List<GameObject> cam;

    private int curCam = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject camera in cam)
        {
            camera.SetActive(false);
        }
        cam[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextCam()
    {//if the button is clicked move to the next camera
        curCam++;
        if(curCam > cam.Count - 1)
        {//we have gone past the list count so go back to zero
            curCam = 0;
            cam[curCam].SetActive(true);
            cam[cam.Count - 1].SetActive(false);
        }
        else
        {
            cam[curCam].SetActive(true);    
            cam[curCam - 1].SetActive(false);
        }
    }

    public void PrevCam()
    {//if the button is clicked move to the previous cam
        curCam--;
        if(curCam < 0)
        {//we have gone below zero so go to the list count max
            curCam = cam.Count - 1;
            cam[curCam].SetActive(true);
            cam[0].SetActive(false);
        }
        else
        {
            cam[curCam].SetActive(true);    
            cam[curCam + 1].SetActive(false);
        }
    }
}
