using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Services;
using SkillBridge.Message;
using System;

public class UILogin : MonoBehaviour
{
    public InputField username;
    public InputField password;



    private void Start()
    {
        UserService.Instance.OnLogin += OnLogin;
    }

    private void OnLogin(Result result, string msg)
    {
        MessageBox.Show(string.Format("结果:{0}, msg:{1}", result, msg));
    }

    public void OnClickLogin()
    {
        if (string.IsNullOrEmpty(username.text))
        {
            MessageBox.Show("请输入登录邮箱");
            return;
        }
        if (string.IsNullOrEmpty(password.text))
        {
            MessageBox.Show("请输入密码");
            return;
        }
        Services.UserService.Instance.SendLogin(username.text, password.text);
    }
}
