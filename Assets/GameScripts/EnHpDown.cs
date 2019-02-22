using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnHpDown : MonoBehaviour
{

    public static Slider hpSlider;
    static Text HPText;

    // Use this for initialization
    public void Start()
    {
        HPText = transform.Find("EHPText").GetComponent<Text>();
        hpSlider = GetComponent<Slider>();

        float maxHp = 70f;
        float nowHp = 70f;


        //スライダーの最大値の設定
        hpSlider.maxValue = maxHp;

        //スライダーの現在値の設定
        hpSlider.value = nowHp;


        HPText = transform.Find("EHPText").GetComponent<Text>();
        HPText.text = hpSlider.value.ToString() + "/" + hpSlider.maxValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void OnEHpDown()
    {
        if (hpSlider.value > 10)
        {
            hpSlider.value -= 10f;

            HPText.text = hpSlider.value.ToString() + "/" + hpSlider.maxValue.ToString();
        }
        else if(hpSlider.value <= 10)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
