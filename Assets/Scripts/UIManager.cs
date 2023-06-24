using System.Collections;
using System.Collections.Generic;
using RiptideNetworking;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour

{
    public GameObject login;
    public GameObject signup;
    private static UIManager _singleton;
    public static UIManager Singleton
    {
        get => _singleton;
        private set
        {
            if (_singleton == null)
                _singleton = value;
            else if (_singleton != value)
            {
                Debug.Log($"{nameof(UIManager)} instance already exists, destroying duplicate!");
                Destroy(value);
            }
        }
    }

    public bool isConnect;
    public string username;

    [Header("For Test")]
    public bool loginSuccess;
    public bool signUpSuccess;
    public bool useDatabase;
    public bool goToMainSick;
    
    
    [Header("UI")]
    [SerializeField] private GameObject loginUI;
    [SerializeField] private GameObject signUpUI;
    [SerializeField] private GameObject chooseUI;
    [SerializeField] private GameObject docUI;
    [SerializeField] private GameObject sickUI;
    [SerializeField] private GameObject loginFailUI;

    [Header("Login")]
    [SerializeField] private InputField emailField_user;
    [SerializeField] private InputField passwordField_user;
    [SerializeField] private Text failText2;
    [SerializeField] private Button loginBtn;


    [Header("SignUp")]
    [SerializeField] private InputField nameField;
    [SerializeField] private InputField usernameField;
    [SerializeField] private InputField emailField;
    [SerializeField] private InputField passwordField;
    [SerializeField] private Text failText; 
    [SerializeField] private Button signUpBtn;
    [SerializeField] private Button signUptoBtn;
    

    private void Awake()
    {
        Singleton = this;
        if(useDatabase && !NetworkManager.Singleton.isConnect){
            Invoke(nameof(Connect),1f);
            Invoke(nameof(SendConnect),2f);
        }
    }


#region Connect
    public void Connect()
    {
        if(!NetworkManager.Singleton.Client.IsConnected){
            NetworkManager.Singleton.Connect();
        }
    }


    public void SendConnect()
    {
        Message message = Message.Create(MessageSendMode.reliable, (ushort)ClientToServerId.connect);
        NetworkManager.Singleton.Client.Send(message);
    }
#endregion

#region Login and SignUp
   
    public void Btn_Login()
    {
            loginBtn.enabled = false ;
            SendLoginData();
    }

    public void Btn_SignUp()
    {
        signUpBtn.enabled = false ;
        SendSignUpData();
    }

    public void Btn_toSignUp()//轉至註冊畫面
    {
        Debug.Log("8");
        signup.SetActive(true);
        login.SetActive(false);
    }
     public void Btn_toLogin()//轉至登入畫面
    {
        Debug.Log("108");
        signup.SetActive(false);
        login.SetActive(true);
    }

    public void SendLoginData()
    {
        Message message = Message.Create(MessageSendMode.reliable, (ushort)ClientToServerId.login);
        message.AddString(emailField_user.text);
        message.AddString(passwordField_user.text);
        NetworkManager.Singleton.Client.Send(message);
    }

    public void SendSignUpData()
    {
        /*if(!CheckSignUpData()) return;*/
        
        Message message = Message.Create(MessageSendMode.reliable, (ushort)ClientToServerId.signUp);
        message.AddString(nameField.text);
        message.AddString(usernameField.text);
        message.AddString(emailField.text);
        message.AddString(passwordField.text);
        NetworkManager.Singleton.Client.Send(message);
    }
    /*
    bool CheckSignUpData()
    {
        if(passwordField.text != passwordConfirmField.text)
        {
            failText.text = "密碼與確認密碼不同";
            return false;
        }else if(usernameField.text == ""){
            failText.text = "請輸入用戶名";
            return false;
        }else if(IDField.text == ""){
            failText.text = "請輸入身分證字號";
            return false;
        }else if(emailField.text == ""){
            failText.text = "請輸入電子信箱";
            return false;
        }else if(phoneNumberField.text == ""){
            failText.text = "請輸入手機號碼";
            return false;
        }else if(passwordField.text == ""){
            failText.text = "請輸入密碼";
            return false;
        }
            
        return true;
    }*/

    public void LoginError(string index)
    {
        loginBtn.enabled= true;
        failText2.text = "帳號密碼錯誤";
        //依照index的數字會造成不同的錯誤
    }
    public void LoginResult( string name, string username, string email)
    {
        FirstLoad.Singleton.islogin=true;
        NoLogin.Singleton.islogin=true;
        SceneManager.LoadScene("game");
            /*if(myID == 0){
                loginUI.SetActive(false);
                chooseUI.SetActive(true);
            }else if(myID == 1){
                SceneManager.LoadScene("MainSick");
            }else{
                SceneManager.LoadScene("UI");
            }*/
        /*else{
            loginFailUI.SetActive(true);
        }*/
    }

    public void SignUpResult(string result )
    {
        signUpBtn.enabled = true;
        Debug.Log("0");
        if(result == "0"){
            failText.text = "註冊成功";
            nameField.text = "";
            usernameField.text = "";
            emailField.text = "";
            /*phoneNumberField.text = "";*/
            passwordField.text = "";
            /*passwordConfirmField.text = "";*/
            Debug.Log("1");
            signup.SetActive(false);
            login.SetActive(true);
        }else{
            failText.text = "註冊失敗，請稍後再試";
        }
        //只要result為0及成功若不為0失敗要做更改
    }

    public void Btn_ChangeLoginAndSignUp()
    {
        loginUI.SetActive(!loginUI.activeSelf);
        signUpUI.SetActive(!loginUI.activeSelf);
        failText.text = "";
    }

    public void BackToMain()
    {
        loginUI.SetActive(true);
        signUpUI.SetActive(false);
       
    }
#endregion

    public void Btn_BackToChoose()
    {
        
        chooseUI.SetActive(true);
    }

    public void Btn_GoToMainApp()
    {
        if(!useDatabase){
            SceneManager.LoadScene(goToMainSick? "MainSick" : "MainDoc");
        }
    }
}
