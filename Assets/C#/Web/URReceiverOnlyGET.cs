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

        // ����JSON�ַ���
        var parameters = JsonUtility.FromJson<URLParameters>(jsonParams);

        // ʹ�ý�����Ĳ���
        Debug.Log("Ticket: " + parameters.ticket);
        Debug.Log("Token: " + parameters.token);
        GlobalVariables.bearerToken = parameters.token;
        GlobalVariables.ticket = parameters.ticket;

        // �������洢�򴫵ݸ��������
        StoreParameters(parameters);
    }

    private void StoreParameters(URLParameters parameters)
    {
        // �洢�����Ա����ʹ��
        PlayerPrefs.SetString("ticket", parameters.ticket);
        PlayerPrefs.SetString("token", parameters.token);

        // �����Ҫ����ʹ����Щ������������StoreParameters�����е�����������
        UseParameters(parameters);
    }

    private void UseParameters(URLParameters parameters)
    {
        // ������ʵ�����ʹ����Щ����
        // ���磬�����������󡢳�ʼ����Ϸ״̬��
    }

    IEnumerator SendGetRequest()
    {
        using (UnityWebRequest www = UnityWebRequest.Get(GetUserInfoURL))
        {
            // ����Authorization Header
            www.SetRequestHeader("Authorization", "Bearer " + GlobalVariables.bearerToken);

            // �������󲢵ȴ���Ӧ
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("����ʧ��: " + www.error);
            }
            else
            {
                Debug.Log("�ɹ���������111: " + www.downloadHandler.text);

                // ����JSON��Ӧ
                try
                {
                    response = JsonUtility.FromJson<ApiResponse>(www.downloadHandler.text);
                    HandleResponse(response);
                }
                catch (Exception e)
                {
                    Debug.LogError("JSON����ʧ��: " + e.Message);
                }
            }
        }
    }

    // ����API��Ӧ�ķ���
    private void HandleResponse(ApiResponse response)
    {
        if (response.success)
        {
            Debug.Log("����ɹ�");
            if (response.rows != null)
            {
                GlobalVariables.userAccount = response.rows.account;
                GlobalVariables.userName = response.rows.username;

                Debug.Log("�˻�: " + response.rows.account);
                Debug.Log("�û���: " + response.rows.username);
            }
            else
            {
                Debug.LogWarning("rows�ֶ�Ϊ��");
            }
            Debug.Log("��Ϣ: " + response.msg);
        }
        else
        {
            Debug.LogError($"����ʧ��: {response.msg} (Code: {response.code})");
        }
    }
}
