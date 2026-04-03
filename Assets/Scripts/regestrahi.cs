using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Firebase.Database;
using Firebase.Auth;
using UnityEngine.UI;




public class regestrahi : MonoBehaviour
{
    DatabaseReference dbRef;
    FirebaseAuth auth;
    public InputField email;
    public InputField pasport;
    public Text tekstInfo;

    [SerializeField] private GameObject Panel1;
    [SerializeField] private GameObject Panel2;
    [SerializeField] private GameObject Panel3;
    [SerializeField] private GameObject Panel4;
    public Text textInfo;

    // Start is called before the first frame update
    void Start()
    {

        auth = FirebaseAuth.DefaultInstance;
        auth.StateChanged += Auth_StateChanged;
        Auth_StateChanged(this, null);
        auth.SignOut();
    }

    private void Auth_StateChanged(object sender, System.EventArgs e)
    {
        if (auth.CurrentUser != null )
        {
            textInfo.text = "Последний пользователь системы  " +auth.CurrentUser.Email;
        }
        else
        {
            textInfo.text = "Вы уверены, что пароль или почта указаны верно?";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonLogin()
    {
        auth.SignInWithEmailAndPasswordAsync(email.text, pasport.text);
    }
    public void ButtonLogin2()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(true);

    }
    public void ButtonRegestr1()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(true);

    }
    public void ButtonRegestr2()
    {
        if (email.text == "")
        {
            Debug.Log("Ошибка стадия 1 нет почты ");

            Application.LoadLevel(2);

        }
        if (pasport.text == "")
        {
            Debug.Log("Ошибка стадия 1 нет пароля ");

            Application.LoadLevel(2);

        }
        else
        {
            Debug.Log("Вошел");
            auth.CreateUserWithEmailAndPasswordAsync(email.text, pasport.text);
            Panel2.SetActive(false);
            Panel3.SetActive(true);
        }

    }
}
