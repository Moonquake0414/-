using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;

[System.Serializable]
public class URLParameters
{
    public string ticket;
    public string token;
}
[System.Serializable]
public class ApiResponse
{
    public bool success;
    public int code;
    public int total;
    public UserRow rows;
    public string msg;
}
[System.Serializable]

public class UserRow
{
    public string account;
    public string username;
}
// 定义用于解析JSON响应的数据类
[System.Serializable]
public class ApiResponse1
{
    public bool success;
    public int code;
    public int total;
    public string msg;
}

// 定义用于序列化为JSON的数据类
[System.Serializable]
public class PostData
{
    public string appId;
    public string ticket;
    public string signature;
    public string userAccount;
    public string userName;
    public long startTime;
    public long endTime;
    public long operateTime;
    public int isFinish;
    public int score;
    public string projectReport;
    public List<Step> steps;

    public PostData() { }
}

[System.Serializable]
public class Step
{
    public string stepCode;
    public string stepName;
    public long satrtTime;
    public long endTime;
    public int usedTime;
    public int experctTime;
    public int maxScore;
    public int score;
    public int repatCount;
    public string evaluation;
    public string scoringModel;

    public Step() { }
}

public class URLReceiver : MonoBehaviour
{
    private string PostURL = "https://api.hnilab.com/api/OpenData/SaveOperateRecordData";
    private string appId = "4da8affef88c4e74b8c1fd442dbe385b57fb3f389fde40ebb32e8c2bdd7c5515";
    private string appSecret = "2D80C7433934307F216C606DA5ECA752B17A122B3D66005014991D8AA2B16" +
        "91995B8D2601129B1E5FD2397A8434C43D388259E8DD68AE81FB315C9F159A9E2CBDDF5308E91CE038E";

    void Start()
    {
        //计算signature
        GlobalVariables.signature = GenerateSignature(appId, appSecret, GlobalVariables.ticket);
    }

    public void OverTestSendPOST()
    {
        //发送带有Authorization Header的POST请求
        StartCoroutine(SendPostRequest(GlobalVariables.signature));
    }

    #region POST请求
    IEnumerator SendPostRequest(string signature)
    {
        // 定义要发送的数据
        var postData = new PostData
        {
            appId = appId,
            ticket = GlobalVariables.ticket,
            signature = signature,
            userAccount = GlobalVariables.userAccount,
            userName = GlobalVariables.userName,
            startTime = GlobalVariables.satrtTime,
            endTime = GlobalVariables.endTime,
            operateTime = GlobalVariables.operateTime,
            isFinish = 1,
            score = GlobalVariables.score,
            projectReport = GlobalVariables.projectReport,
            steps = new List<Step>
            {
                new Step//1
                {
                    //stepCode = "555",
                    stepName = "图像压缩编码基本原理",
                    satrtTime = GlobalVariables.satrtTime,
                    endTime = GlobalVariables.FirstTimeOver,
                    usedTime = GlobalVariables.FirstTime,
                    experctTime = 360,
                    maxScore = 10,
                    score = GlobalVariables.FirstScore,
                    //repatCount = 1,
                    //evaluation = "良好",
                    //scoringModel = "标准模型"
                },
                new Step//2
                {
                    //stepCode = "555",
                    stepName = "图像压缩编码模型",
                    satrtTime = GlobalVariables.SecondTimeBegin,
                    endTime = GlobalVariables.SecondTimeOver, 
                    usedTime = GlobalVariables.SecondTime,
                    experctTime = 360,
                    maxScore = 10,
                    score = GlobalVariables.SecondScore,
                    //repatCount = 1,
                    //evaluation = "良好",
                    //scoringModel = "标准模型"
                },
                new Step//3
                {
                    //stepCode = "555",
                    stepName = "图像压缩方法分类",
                    satrtTime = GlobalVariables.ThirdTimeBegin,
                    endTime = GlobalVariables.ThirdTimeOver,
                    usedTime = GlobalVariables.ThirdTime,
                    experctTime = 360,
                    maxScore = 10,
                    score = GlobalVariables.ThirdScore,
                    //repatCount = 1,
                    //evaluation = "良好",
                    //scoringModel = "标准模型"
                },
                new Step//4
                {
                    //stepCode = "555",
                    stepName = "图像压缩编码的性能分析",
                    satrtTime = GlobalVariables.FourthTimeBegin,
                    endTime = GlobalVariables.FourthTimeOver,
                    usedTime = GlobalVariables.FourthTime,
                    experctTime = 360,
                    maxScore = 16,
                    score = GlobalVariables.FourthScore,
                    //repatCount = 1,
                    //evaluation = "良好",
                    //scoringModel = "标准模型"
                },
                new Step//5
                {
                    //stepCode = "555",
                    stepName = "图像压缩编码的应用",
                    satrtTime = GlobalVariables.FifthTimeBegin,
                    endTime = GlobalVariables.FifthTimeOver,
                    usedTime = GlobalVariables.FifthTime,
                    experctTime = 360,
                    maxScore = 4,
                    score = GlobalVariables.FifthScore,
                    //repatCount = 1,
                    //evaluation = "良好",
                    //scoringModel = "标准模型"
                },
                new Step//6
                {
                    //stepCode = "555",
                    stepName = "图像压缩编码流程设计",
                    satrtTime = GlobalVariables.SixthTimeBegin,
                    endTime = GlobalVariables.SixthTimeOver,
                    usedTime = GlobalVariables.SixthTime,
                    experctTime = 360,
                    maxScore = 10,
                    score = GlobalVariables.SixthScore,
                    //repatCount = 1,
                    //evaluation = "良好",
                    //scoringModel = "标准模型"
                },
                new Step//7
                {
                    //stepCode = "555",
                    stepName = "霍夫曼压缩编码",
                    satrtTime = GlobalVariables.SeventhTimeBegin,
                    endTime = GlobalVariables.SeventhTimeOver,
                    usedTime = GlobalVariables.SeventhTime,
                    experctTime = 360,
                    maxScore = 10,
                    score = GlobalVariables.SeventhScore,
                    //repatCount = 1,
                    //evaluation = "良好",
                    //scoringModel = "标准模型"
                },
                new Step//8
                {
                    //stepCode = "555",
                    stepName = "算术编码",
                    satrtTime = GlobalVariables.EighthTimeBegin,
                    endTime = GlobalVariables.EighthTimeOver,
                    usedTime = GlobalVariables.EighthTime,
                    experctTime = 360,
                    maxScore = 4,
                    score = GlobalVariables.EighthScore,
                    //repatCount = 1,
                    //evaluation = "良好",
                    //scoringModel = "标准模型"
                },
                new Step//9
                {
                    //stepCode = "555",
                    stepName = "DPCM编码",
                    satrtTime = GlobalVariables.NinthTimeBegin,
                    endTime = GlobalVariables.NinthTimeOver,
                    usedTime = GlobalVariables.NinthTime,
                    experctTime = 360,
                    maxScore = 16,
                    score = GlobalVariables.NinthScore,
                    //repatCount = 1,
                    //evaluation = "良好",
                    //scoringModel = "标准模型"
                },
                new Step//10
                {
                    //stepCode = "555",
                    stepName = "DCT变换编码",
                    satrtTime = GlobalVariables.TenthTimeBegin,
                    endTime = GlobalVariables.TenthTimeOver,
                    usedTime = GlobalVariables.TenthTime,
                    experctTime = 360,
                    maxScore = 0,
                    score = GlobalVariables.TenthScore,
                    //repatCount = 1,
                    //evaluation = "良好",
                    //scoringModel = "标准模型"
                },
                new Step//11
                {
                    //stepCode = "555",
                    stepName = "JPEG压缩实例",
                    satrtTime = GlobalVariables.EleventhTimeBegin,
                    endTime = GlobalVariables.EleventhTimeOver,
                    usedTime = GlobalVariables.EleventhTime,
                    experctTime = 360,
                    maxScore = 10,
                    score = GlobalVariables.EleventhScore,
                    //repatCount = 1,
                    //evaluation = "良好",
                    //scoringModel = "标准模型"
                }
            }
        };
        
        // 将对象转换为JSON字符串
        string jsonData = JsonUtility.ToJson(postData);
        
        // 创建UnityWebRequest对象
        using (UnityWebRequest www = new UnityWebRequest(PostURL, "POST"))
        {
            // 设置请求头
            www.SetRequestHeader("Authorization", "Bearer " + GlobalVariables.bearerToken);
            www.SetRequestHeader("Content-Type", "application/json");

            // 设置请求体
            byte[] bodyRaw = Encoding.UTF8.GetBytes(jsonData);
            www.uploadHandler = new UploadHandlerRaw(bodyRaw);
            www.downloadHandler = new DownloadHandlerBuffer();

            // 发送请求并等待响应
            yield return www.SendWebRequest();
            
            //提前检查签名
            Debug.Log(GlobalVariables.signature);
            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("请求失败: " + www.error);
            }
            else
            {
                Debug.Log("成功接收数据: " + www.downloadHandler.text);

                // 解析JSON响应
                try
                {
                    ApiResponse response = JsonUtility.FromJson<ApiResponse>(www.downloadHandler.text);
                    HandleResponse1(response);
                }
                catch (System.Exception e)
                {
                    Debug.LogError("JSON解析失败: " + e.Message);
                }
            }
        }
    }

    // 处理API响应的方法
    private void HandleResponse1(ApiResponse response)
    {
        if (response.success && response.msg == "操作成功")
        {
            Debug.Log("请求成功");
            Debug.Log("消息: " + response.msg);
        }
        else
        {
            Debug.LogError($"请求失败: {response.msg} (Code: {response.code})");
        }
    }

    // 生成签名的方法
    private string GenerateSignature(string appId, string appSecret, string ticket)
    {
        string input = appId + appSecret + ticket;
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // 将得到的哈希值转换为十六进制字符串
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            string result = sb.ToString().ToLower();
            return result;
        }
    }
    #endregion
}

