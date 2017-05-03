using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        //課題　要素数5の配列を初期化する
        int[] array = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < array.Length; i++)
        {
            //課題　各要素の値を順番に表示
            Debug.Log(array[i]);
        }
        //課題 各要素の値を逆順に表示
        Debug.Log("課 題 2");
        for (int i = array.Length - 1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
//発展課題　　魔法攻撃用の関数を呼び出す
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
       
    }
   

    // Update is called once per frame
    void Update () {
		
	}
}
