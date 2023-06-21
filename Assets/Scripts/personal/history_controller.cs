using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class history_controller : MonoBehaviour
{
    public GameObject ingrouppanel;
    public GameObject endgrouppanel;
    public GameObject ingroupline;
    public GameObject endgroupline;

    // Start is called before the first frame update
    void Start()
    {
        ingrouppanel.SetActive(true);
        ingroupline.SetActive(true);
        endgrouppanel.SetActive(false);
        endgroupline.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void clickingroup()
    {
        ingrouppanel.SetActive(true);
        ingroupline.SetActive(true);
        endgrouppanel.SetActive(false);
        endgroupline.SetActive(false);
    }
    void clickendgroup()
    {
        ingrouppanel.SetActive(false);
        ingroupline.SetActive(false);
        endgrouppanel.SetActive(true);
        endgroupline.SetActive(true);
    }
}
