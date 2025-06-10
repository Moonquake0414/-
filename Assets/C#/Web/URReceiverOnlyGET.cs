using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class ApiResponse0
{
    public bool success;
    public int code;
    public int total;
    public UserRow rows;
    public string msg;
}

public class URReceiverOnlyGET : MonoBehaviour
{
    private ApiResponse response;

    private string GetUserInfoURL = "https://api.hnilab.com/api/OpenData/GetUserInfo";

    void Start()
    {
        StartCoroutine(SendGetRequest());
    }

    public void SetURLParameters(string jsonParams)
    {
        Debug.Log("Received URL parameters: " + jsonParams);

        // 解析JSON字符串
        var parameters = JsonUtility.FromJson<URLParameters>(jsonParams);

        // 使用解析后的参数
        Debug.Log("Ticket: " + parameters.ticket);
        Debug.Log("Token: " + parameters.token);
        GlobalVariables.bearerToken = parameters.token;
        GlobalVariables.ticket = parameters.ticket;

        // 将参数存储或传递给其他组件
        StoreParameters(parameters);
    }

    private void StoreParameters(URLParameters parameters)
    {
        // 存储参数以便后续使用
        PlayerPrefs.SetString("ticket", parameters.ticket);
        PlayerPrefs.SetString("token", parameters.token);

        // 如果需要立即使用这些参数，可以在StoreParameters方法中调用其他方法
        UseParameters(parameters);
    }

    private void UseParameters(URLParameters parameters)
    {
        // 在这里实现如何使用这些参数
        // 例如，发送网络请求、初始化游戏状态等
    }

    IEnumerator SendGetRequest()
    {
        using (UnityWebRequest www = UnityWebRequest.Get(GetUserInfoURL))
        {
            // 设置Authorization Header
            www.SetRequestHeader("Authorization", "Bearer " + GlobalVariables.bearerToken);

            // 发送请求并等待响应
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("请求失败: " + www.error);
            }
            else
            {
                Debug.Log("成功接收数据111: " + www.downloadHandler.text);

                // 解析JSON响应
                try
                {
                    response = JsonUtility.FromJson<ApiResponse>(www.downloadHandler.text);
                    HandleResponse(response);
                }
                catch (Exception e)
                {
                    Debug.LogError("JSON解析失败: " + e.Message);
                }
            }
        }
    }

    // 处理API响应的方法
    private void HandleResponse(ApiResponse response)
    {
        if (response.success)
        {
            Debug.Log("请求成功");
            if (response.rows != null)
            {
                GlobalVariables.userAccount = response.rows.account;
                GlobalVariables.userName = response.rows.username;

                Debug.Log("账户: " + response.rows.account);
                Debug.Log("用户名: " + response.rows.username);
            }
            else
            {
                Debug.LogWarning("rows字段为空");
            }
            Debug.Log("消息: " + response.msg);
        }
        else
        {
            Debug.LogError($"请求失败: {response.msg} (Code: {response.code})");
        }
    }
}
