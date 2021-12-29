using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public InputField registerEmail;
    public InputField registerPassword;
    public InputField ConfirmPassword;
    public Toggle agreeTerms;

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
        //UserServices.Instance.sendMassage(registerEmail.text, registerPassword.text);
    }
}
