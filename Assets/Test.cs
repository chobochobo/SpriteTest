using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int mp = 53;  // MP

    // 攻撃用の関数
    public void Magic()
    {
        if (mp > 5)
        {
            this.mp = this.mp - 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPがたらない");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        Boss bosstest = new Boss();

        for (int i = 0; i < 11; i++)
        {
            bosstest.Magic();
        }


        // 要素数5の配列を初期化する
        int[] arrey = new int[5];

        // 配列の各要素の値を順番に表示
        arrey[0] = 15;
        arrey[1] = 25;
        arrey[2] = 35;
        arrey[3] = 45;
        arrey[4] = 55;

        // 配列の各要素の値を順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(arrey[i]);
        }

        // 配列の各要素の値を逆順に表示
        for (int i = 4; i > 0; i--)
        {
            Debug.Log(arrey[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
