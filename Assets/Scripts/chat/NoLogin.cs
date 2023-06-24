using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//位置在talk場景裡面的Main camera
public class NoLogin : MonoBehaviour
{
    private static NoLogin _singleton;
    public static NoLogin Singleton
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
    }
    public bool firstLoad=true;
    public bool islogin;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /*public void load_signin()
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
    }*/
}