using System.Collections;
using System.Collections.Generic;
using RiptideNetworking;
using UnityEngine;
using UnityEngine.UI;

public class chat_controller : MonoBehaviour
{
    private static chat_controller _singleton;
    public static chat_controller Singleton
    {
        get => _singleton;
        private set
        {
            if (_singleton == null)
                _singleton = value;
            else if (_singleton != value)
            {
                Debug.Log($"{nameof(chat_controller)} instance already exists, destroying duplicate!");
                Destroy(value.gameObject);
            }
        }
    }
    private void Awake()
    {
        Singleton = this;
    }

    public GameObject main_chat;
    public GameObject main_friend;
    public GameObject main_chatting;
    public GameObject main_group;
    public GameObject chatting_friend;
    public GameObject chatting_group;
    public GameObject signupfirst;
    
    
    [Header("chat")]
    public Transform chatCollection;
    public GameObject localchatBox;
    public GameObject anotherchatBox; 
    public InputField chatInput;
    
    // Start is called before the first frame update
    void Start()
    {
        main_chat.SetActive(true);
        chatting_friend.SetActive(false);
        chatting_group.SetActive(false);
        main_chatting.SetActive(true);
        main_friend.SetActive(false);
        main_group.SetActive(false);
        if(NoLogin.Singleton.islogin==false){
            signupfirst.SetActive(true);
            Debug.Log("10");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (group_jointochat.jointochat == 1)
        {
            chatting_friend.SetActive(true);
            group_jointochat.jointochat = 0;
        }
    }

    public void sendChat(string chat)
    {
        Instantiate(localchatBox,chatCollection).GetComponent<chatting>().Init(chat);//會呼叫chatting.cs去作業
    }

    public void Btn_sendChat()
    {
        Message message = Message.Create(MessageSendMode.reliable, (ushort)ClientToServerId.sendChat);
        message.AddString(chatInput.text);
        NetworkManager.Singleton.Client.Send(message);  
    }

    void backtochat()
    {
        main_chat.SetActive(true);
        chatting_friend.SetActive(false);
        chatting_group.SetActive(false);
    }

    void button_chat()
    {
        main_chatting.SetActive(true);
        main_friend.SetActive(false);
        main_group.SetActive(false);
    }
    void button_friend()
    {
        main_chatting.SetActive(false);
        main_friend.SetActive(true);
        main_group.SetActive(false);
    }
    void button_group()
    {
        main_chatting.SetActive(false);
        main_friend.SetActive(false);
        main_group.SetActive(true);
    }

    void enter_friend()
    {
        main_chat.SetActive(false);
        chatting_friend.SetActive(true);
        chatting_group.SetActive(false);
    }

    void enter_group()
    {
        main_chat.SetActive(false);
        chatting_friend.SetActive(false);
        chatting_group.SetActive(true);
    }
    /*void button_signupfirst()
    {
        signupfirst.SetActive(false);
        
    }*/
}
