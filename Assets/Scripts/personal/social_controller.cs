using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class social_controller : MonoBehaviour
{
    public GameObject heart;
    public GameObject heart_click;
    public GameObject pluspanel;
    // Start is called before the first frame update
    void Start()
    {
        heart.SetActive(true);
        heart_click.SetActive(false);
        pluspanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void likecomment()
    {
        heart.SetActive(false);
        heart_click.SetActive(true);
    }
    void nolikecomment()
    {
        heart.SetActive(true);
        heart_click.SetActive(false);
    }

    void postiswrite()
    {
        pluspanel.SetActive(true);
    }

    void postiscancel()
    {
        pluspanel.SetActive(false);
    }
    void postissuccess()
    {
        pluspanel.SetActive(false);
    }
}
