using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
      public InputField usernameField;
      public InputField passwordField;
      public Text registrationMessage;

    public void Registration()
    {
        string username = usernameField.text;
        string password = passwordField.text;

        // Check if the username already exists.
        if (!PlayerPrefs.HasKey(username))
        {
            PlayerPrefs.SetString(username, password);
            PlayerPrefs.Save();
            registrationMessage.text = "Registration successful";
        }
        else
        {
            registrationMessage.text = "Username already exists. Please choose a different one.";
        }
    }
}
