using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chatting : MonoBehaviour
{
   public Text chat;
   public void Init(string _chat)
   {
        chat.text =_chat;//
   }
}
