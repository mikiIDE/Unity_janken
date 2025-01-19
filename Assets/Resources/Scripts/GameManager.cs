using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // シーンをリセットするために必要

public class GameManager : MonoBehaviour
{
    //EnemyManager内の関数を使えるようになる
    public EnemyManager enemyManager;

    //じゃんけん結果の表示テキスト
    public TextMeshProUGUI judgeText;

    /// <summary>
    /// 機能1:ここでジャンケンの結果判定をします。
    /// 機能2:判定結果を画面にテキスト表示します。    
    /// </summary>
    /// <param name="playerHand"></param>
    public void JankenResult(int playerHand)
    {
        // enemyManager.csの関数Judgement();を呼び出す
        // 結果 : CPUの出す手が画面に表示される
        enemyManager.Judgement();

        //playerHand...0:グー、1:チョキ、2:パー
        //enemyHand...0:グー、1:チョキ、2:パー
        if (playerHand == enemyManager.enemyHand)
        {
            // テキストが表示される
            judgeText.text = "あいこで...";
        }
        // プレイヤーが勝つ場合
        // playerHand(グー)でenemyHand(チョキ)
        // playerHand(チョキ)でenemyHand(パー)
        // playerHand(パー)でenemyHand(グー)
        else if (
            (playerHand == 0 && enemyManager.enemyHand == 1) ||
            (playerHand == 1 && enemyManager.enemyHand == 2) ||
            (playerHand == 2 && enemyManager.enemyHand == 0)
            )
        {
            judgeText.text = "あなたの勝ち";
        }
        // プレイヤーが負ける場合 → あいこと勝ち以外
        else
        {
            judgeText.text = "あなたの負け";
        }
    }
    /// <summary>
    /// リセットボタンを押すと初期状態に戻る
    /// </summary>
    public void ResetScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
