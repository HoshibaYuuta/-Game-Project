using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpDown : MonoBehaviour
{


    public static Slider hpSlider;
    static Text HPText;

    // Use this for initialization
    public void Start()
    {
        HPText = transform.Find("PHPText").GetComponent<Text>();
        hpSlider = GetComponent<Slider>();

        float maxHp = 100f;
        float nowHp = 100f;


        //スライダーの最大値の設定
        hpSlider.maxValue = maxHp;

        //スライダーの現在値の設定
        hpSlider.value = nowHp;

        //Hptextに探してきたHptextのtextを入れる
        HPText = transform.Find("PHPText").GetComponent<Text>();

        //Hptextに今のHpの値/マックスHPの値を入れる
        HPText.text = hpSlider.value.ToString() + "/" + hpSlider.maxValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void OnHpDown()
    {
        if (hpSlider.value > 10)
        {
            hpSlider.value -= 10f;

            HPText.text = hpSlider.value.ToString() + "/" + hpSlider.maxValue.ToString();
        }
        else
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}

