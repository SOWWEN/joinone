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
    //public bool firstLoad=true;
    // Start is called before the first frame update
    void Start()
    {
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
}