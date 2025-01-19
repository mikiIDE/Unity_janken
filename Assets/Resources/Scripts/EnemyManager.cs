using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // CPUの手
    public int enemyHand;
    // SpriteRenderer（グー、チョキ、パーを取得）
    private SpriteRenderer spriteRenderer;
    // ジャンケン画像配列 [0:グーの画像, 1:チョキの画像, 2:パーの画像]
    public Sprite[] sprites;


    // Start is called before the first frame update
    void Start()
    {
        // 再生ボタンが押された直後にSpriteRendererを取得
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// CPUの手を決めて画面に手を表示する関数
    /// </summary>
    public void Judgement()
    {
        // ジャンケンのランダム生成（じゃんけんの手を決める）
        enemyHand = Random.Range(0, 3);
        switch (enemyHand)
        {
            case 0:
                spriteRenderer.sprite = sprites[0];
                break;
            case 1:
                spriteRenderer.sprite = sprites[1];
                break;
            case 2:
                spriteRenderer.sprite = sprites[2];
                break;
        }
    }
}
