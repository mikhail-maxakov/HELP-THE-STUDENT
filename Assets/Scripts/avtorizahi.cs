using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class avtorizahi : MonoBehaviour
{

    [SerializeField] private GameObject Panel1;
    [SerializeField] private GameObject Panel2;
    [SerializeField] private GameObject Panel3;
    [SerializeField] private GameObject Panel4;
    [SerializeField] private InputField Hislo1;
    [SerializeField] private InputField Hislo2;


    public void Avtoriz()
    {
        if (Hislo1.text == "")
        {
            Debug.Log("Ошибка стадия 1 нет почты ");
            Application.LoadLevel(2);


        }
        if (Hislo2.text == "")
        {
            Debug.Log("Ошибка стадия 1 нет пароля ");

            Application.LoadLevel(2);

        }
        else
        {
            Panel1.SetActive(false);
            Panel2.SetActive(false);
            Panel3.SetActive(false);
            Panel4.SetActive(true);
        }

    }
}
