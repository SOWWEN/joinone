using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class group_controller : MonoBehaviour
{
    public GameObject main_grouppage;
    public GameObject create_group;
    public GameObject data_group1;
    public GameObject data_group2;
    public string ChatScene;
    // Start is called before the first frame update
    void Start()
    {
        main_grouppage.SetActive(true);
        create_group.SetActive(false);
        data_group1.SetActive(false);
        data_group2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void enter_group1data()
    {
        main_grouppage.SetActive(false);
        data_group1.SetActive(true);
    }
    void enter_group2data()
    {
        main_grouppage.SetActive(false);
        data_group2.SetActive(true);
    }

    void add_newgroup()
    {
        main_grouppage.SetActive(false);
        create_group.SetActive(true);
    }

    void create_newgroup()
    {
        main_grouppage.SetActive(true);
        create_group.SetActive(false);
    }

    void backtogroup()
    {
        main_grouppage.SetActive(true);
        create_group.SetActive(false);
        data_group1.SetActive(false);
        data_group2.SetActive(false);
    }

    void jointhegroup()
    {
        group_jointochat.jointochat = 1;
        SceneManager.LoadScene(ChatScene);
    }
}
