using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    /*private static GameController _singleton;
    public static GameController Singleton
    {
        get => _singleton;
        private set
        {
            if (_singleton == null)
                _singleton = value;
            else if (_singleton != value)
            {
                Debug.Log($"{nameof(GameController)} instance already exists, destroying duplicate!");
                Destroy(value);
            }
        }
    }
    private void Awake()
    {
        Singleton = this;
    }*/
    public string SignScene;
    public string GroupScene;
    public string ChatScene;
    public string GameScene;
    public string PersonalScene;
    public GameObject LogOut; 
    public GameObject signupfirst;
    public GameObject Login;
    public GameObject Logout;
    //bool trigger2=false;
    //public bool firstLoad=true;
    // Start is called before the first frame update
    void Start()
    {
        if(FirstLoad.Singleton.islogin==true && SceneManager.GetActiveScene().name=="personal"){
            Debug.Log("6");
            Login.SetActive(false);
            Logout.SetActive(true);
        }
        if(NoLogin.Singleton.islogin==true && SceneManager.GetActiveScene().name=="talk"){
            Debug.Log("8");
            signupfirst.SetActive(false);
            Debug.Log("9");
        }
        /*else if(Logout==false && SceneManager.GetActiveScene().name=="personal"){
            Debug.Log("5");
            Login.SetActive(false);
            Logout.SetActive(true);
        }*/
        //DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void load_signin()
    {
        SceneManager.LoadScene(SignScene);
    }
    public void load_talk()
    {
        SceneManager.LoadScene(ChatScene);
    }
    public void load_group()
    {
        SceneManager.LoadScene(GroupScene);
    }
    public void load_personal()
    {
        SceneManager.LoadScene(PersonalScene);
    }
    public void load_game()
    {
        SceneManager.LoadScene(GameScene);
    }
    public void load_signupfirst()
    {
        SceneManager.LoadScene(0);

    }
     public void load_LogOut()
    {
        Debug.Log("123");
        SceneManager.LoadScene(GameScene);
        Login.SetActive(true);
        Logout.SetActive(false);
        //signupfirst.SetActive(true);
        FirstLoad.Singleton.islogin=false;
        //FirstLoad.Singleton.firstLoad=true;
        NoLogin.Singleton.islogin=false;
        //NoLogin.Singleton.firstLoad=true;
    }
}