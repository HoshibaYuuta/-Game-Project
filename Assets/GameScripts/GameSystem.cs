using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour {

	public void GameStart()
    {
        SceneManager.LoadScene("OP2 Scene");
    }

    public void ShootingStart()
    {
        SceneManager.LoadScene("GameScene");
    }



    public void GameTitle()
    {
        SceneManager.LoadScene("OP1 Scene");
    }

    //ゲーム終了ボタンを押したら実行
    public void GameEnd()
    {

        UnityEditor.EditorApplication.isPlaying = false;

    }
}
