using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputExample : MonoBehaviour
{
    public static string PlayerName;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetText()
    {
        //InputFieldのTextコンポーネントを取得
        Text inputText = GameObject.Find("InputField/Text").GetComponent<Text>();

        //Text型をstring型に変換
        string name = inputText.text;

        Debug.Log(name);

        // stTarget を Char 型の 1 次元配列に変換する
        char[] chArray1 = name.ToCharArray();

        PlayerName = name;
    }

}
