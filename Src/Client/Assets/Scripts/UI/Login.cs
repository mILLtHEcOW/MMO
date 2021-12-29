using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField loginEmail;
    public InputField loginPassword;
    public Toggle rememberThePassword;
    public Toggle agreeTerms;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnClickLogin()
    {
        if (string.IsNullOrEmpty(loginEmail.text))
        {
            
        }
        if (string.IsNullOrEmpty(loginPassword.text))
        {

        }
        if (!rememberThePassword.isOn)
        {

        }
        if (!agreeTerms.isOn)
        {

        }
        UserServices.Instance.sendLogin(loginEmail.text, loginPassword.text);
    }
}
