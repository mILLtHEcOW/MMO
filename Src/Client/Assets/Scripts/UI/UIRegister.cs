using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Services;
using SkillBridge.Message;
using System;

public class UIRegister : MonoBehaviour
{
    public InputField registerEmail;
    public InputField registerPassword;
    public InputField ConfirmPassword;
    public Toggle agreeTerms;

    private void Start()
    {
        UserService.Instance.OnRegister += OnRegister;
    }

    private void OnRegister(Result result, string msg)
    {
        MessageBox.Show(string.Format("结果:{0}, msg:{1}", result, msg));
    }

    public void OnClickRegister()
    {
        if (string.IsNullOrEmpty(registerEmail.text))
        {
            MessageBox.Show("请输入登录邮箱");
            return;
        }
        if (string.IsNullOrEmpty(registerPassword.text))
        {
            MessageBox.Show("请输入登录密码");
            return;
        }
        if (string.IsNullOrEmpty(ConfirmPassword.text))
        {
            MessageBox.Show("请输入确认密码");
            return;
        }
        if (registerPassword.text != ConfirmPassword.text)
        {
            MessageBox.Show("两次密码不一致");
            return;
        }
        if (!agreeTerms.isOn)
        {
            MessageBox.Show("请阅读并同意《用户协议》");
            return;
        }

        UserService.Instance.SendRegister(registerEmail.text, registerPassword.text);
    }
}
