using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personal_controller : MonoBehaviour
{
    public GameObject main_personalpage;
    public GameObject prizepanel;
    public GameObject historypanel;
    public GameObject socialpanel;
    public GameObject calenderpanel;
    public GameObject settingpanel;

    // Start is called before the first frame update
    void Start()
    {
        main_personalpage.SetActive(true);
        prizepanel.SetActive(false);
        historypanel.SetActive(false);
        socialpanel.SetActive(false);
        calenderpanel.SetActive(false);
        settingpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void enter_prize()
    {
        main_personalpage.SetActive(false);
        prizepanel.SetActive(true);
    }

    void enter_history()
    {
        main_personalpage.SetActive(false);
        historypanel.SetActive(true);
    }
    void enter_social()
    {
        main_personalpage.SetActive(false);
        socialpanel.SetActive(true);
    }
    void enter_calender()
    {
        main_personalpage.SetActive(false);
        calenderpanel.SetActive(true);
    }
    void enter_setting()
    {
        main_personalpage.SetActive(false);
        settingpanel.SetActive(true);
    }

    void backtopersonal()
    {
        main_personalpage.SetActive(true);
        prizepanel.SetActive(false);
        historypanel.SetActive(false);
        socialpanel.SetActive(false);
        calenderpanel.SetActive(false);
        settingpanel.SetActive(false);
    }
}
