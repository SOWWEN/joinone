using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prize_controller : MonoBehaviour
{
    public GameObject mainprizepanel;
    public GameObject levelpanel;
    public GameObject timepanel;
    public GameObject partnerpanel;
    // Start is called before the first frame update
    void Start()
    {
        levelpanel.SetActive(false);
        timepanel.SetActive(false);
        partnerpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void enter_level()
    {
        levelpanel.SetActive(true);
        mainprizepanel.SetActive(false);
    }
    void enter_time()
    {
        timepanel.SetActive(true);
        mainprizepanel.SetActive(false);
    }
    void enter_partner()
    {
        partnerpanel.SetActive(true);
        mainprizepanel.SetActive(false);
    }

    void backtomainprize()
    {
        mainprizepanel.SetActive(true);
        levelpanel.SetActive(false);
        timepanel.SetActive(false);
        partnerpanel.SetActive(false);
    }
}
