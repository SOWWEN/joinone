using RiptideNetworking;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Dictionary<ushort, Player> list = new Dictionary<ushort, Player>();

    public ushort Id { get; private set; }
    public bool IsLocal { get; private set; }

    private string username;

    private void OnDestroy()
    {
        list.Remove(Id);
    }

    public static void Spawn(ushort id)
    {
        Player player;

        player = Instantiate(GameLogic.Singleton.LocalPlayerPrefab).GetComponent<Player>();
        if (id == NetworkManager.Singleton.Client.Id)
        {
            player.Id=id;
        }
        else
        {
            Debug.Log($"some prblem");
            player.Id = NetworkManager.Singleton.Client.Id;
        }
        NetworkManager.Singleton.isConnect = true;

        UIManager.Singleton.isConnect = true;
    
        list.Add(id, player);
    }

    [MessageHandler((ushort)ServerToClientId.playerSignUp)]
    private static void SpawnPlayer(Message message)
    {
        Spawn(message.GetUShort());
    }

    public static void GetLoginResult(string name, string username, string email)
    {
        UIManager.Singleton.LoginResult( name, username, email);
    }

    [MessageHandler((ushort)ServerToClientId.loginResult)]
    private static void LoginResult(Message message)
    {
        GetLoginResult( message.GetString(), message.GetString(), message.GetString());
    }

    public static void GetSignUpResult(string result)
    {
        UIManager.Singleton.SignUpResult(result);
    }

    [MessageHandler((ushort)ServerToClientId.signUpResult)]
    private static void SignUpResult(Message message)
    {
        GetSignUpResult(message.GetString());
    }

    public static void LoginError(string index)
    {
        UIManager.Singleton.LoginError(index);
    }

    [MessageHandler((ushort)ServerToClientId.loginError)]
    private static void LoginError(Message message)
    {
        LoginError(message.GetString());
    }
    public static void sendChat(string chat)
    {
        chat_controller.Singleton.sendChat(chat);
    }

    [MessageHandler((ushort)ServerToClientId.sendChat)]
    private static void sendChat(Message message)
    {
        sendChat(message.GetString());
    }
}
