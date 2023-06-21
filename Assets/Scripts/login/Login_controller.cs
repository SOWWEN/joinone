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
        }
    }

    // Update is called once per frame
    void Update()
    {   
        if(!FirstLoad.Singleton.firstLoad) return;//如果是第一次登入會執行下面，若不是則不會執行
        this.open_time += Time.deltaTime;
        if (this.open_time > this.transfrom_login)
        {
            if(!trigger){
                SceneManager.LoadScene(5);
                /*SceneManager.LoadScene(GameScene);
                open.SetActive(false);
                login.SetActive(true);*/
                FirstLoad.Singleton.firstLoad=false;
                trigger=true;
                
            }

        }
    }
    /*public void load_game()
    {
        SceneManager.LoadScene(GameScene);
    }*/

    /*void newaccount()
    {
        if(open.SetActive(true)){
            signup.SetActive(true);
            login.SetActive(false);
        }
    }*/

    /*void backtologin()
    {
        if(Log==1){
        signup.SetActive(false);
        login.SetActive(true);
        }

    }*/
}

