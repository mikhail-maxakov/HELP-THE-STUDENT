using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perexod : MonoBehaviour
{
    public void Ruzrab()
    {
        Application.LoadLevel(1);
    }
    public void Menu()
    {
        Application.LoadLevel(0);
    }
    public void Avtorisa()
    {
        Application.LoadLevel(2);
    }
    public void ExitGameFunction()
    {
        Application.Quit();
    }
    public void Avtor()
    {
        Application.LoadLevel(3);
    }
}
