using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calender_controller : MonoBehaviour
{
    public GameObject activitybutton;
    public GameObject deletebutton;

    // Start is called before the first frame update
    void Start()
    {
        deletebutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void activityclick()
    {
        deletebutton.SetActive(true);

    }

    void activitycanel()
    {
        deletebutton.SetActive(false);
        activitybutton.SetActive(true);
    }

    void activitydelete()
    {
        Destroy(activitybutton);
        Destroy(deletebutton);
    }
}
