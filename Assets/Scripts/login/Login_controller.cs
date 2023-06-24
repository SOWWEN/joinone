using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Login_controller : MonoBehaviour
{
    public GameObject open;
    public GameObject login;
    public GameObject signup;
    //public string GameScene;

    float transfrom_login = 2.0f;
    float open_time = 0;
    bool trigger;
    // Start is called before the first frame update
    void Start()
    {
        if(FirstLoad.Singleton.firstLoad){
            open.SetActive(true);
            login.SetActive(false);
            signup.SetActive(false);
            Debug.Log("0");
        }
    }

    // Update is called once per frame
    void Update()
    {   
        
        if(!FirstLoad.Singleton.firstLoad) return;//如果是第一次登入會執行下面，若不是則不會執行
        //if(!NoLogin.Singleton.firstLoad) return;
        this.open_time += Time.deltaTime;
        if (this.open_time > this.transfrom_login)
        {
            if(!trigger){
                SceneManager.LoadScene(5);
                //*SceneManager.LoadScene(GameScene);
                open.SetActive(false);
                //login.SetActive(true);
                FirstLoad.Singleton.firstLoad=false;
                NoLogin.Singleton.firstLoad=false;
                trigger=true;
            } 
            //login.SetActive(true);
        }
        Debug.Log("4");
    }  
    void newaccount()
    {
        Debug.Log("0");
        signup.SetActive(false);
        login.SetActive(true);
    }

    /*void backtologin()
    {
        if(Log==1){
        signup.SetActive(false);
        login.SetActive(true);
        }

    }*/
}

