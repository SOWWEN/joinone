using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chat_controller : MonoBehaviour
{
    public GameObject main_chat;
    public GameObject main_friend;
    public GameObject main_chatting;
    public GameObject main_group;
    public GameObject chatting_friend;
    public GameObject chatting_group;

    // Start is called before the first frame update
    void Start()
    {
        main_chat.SetActive(true);
        chatting_friend.SetActive(false);
        chatting_group.SetActive(false);
        main_chatting.SetActive(true);
        main_friend.SetActive(false);
        main_group.SetActive(false);
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
}
