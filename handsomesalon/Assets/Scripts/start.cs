using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void PlayGame()
    {
        //呼叫第一場景
        SceneManager.LoadScene(1);
    }

    public void SaveData()
    {
        //已儲存的遊玩檔案
        SceneManager.LoadScene(4);
    }

    public void GameSet()
    {
        //遊戲設定頁面
        SceneManager.LoadScene(3);
    }

    public void Encyclopedia()
    {
        //呼叫圖鑑
        SceneManager.LoadScene(5);
    }
}
