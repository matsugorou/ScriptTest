using UnityEngine;
using System.Collections;

public class Boss {
    private int hp = 100;　　　//体力
    private int power = 25;  //攻撃力
    private int mp = 53;       //MPを初期化

    //攻撃用の関数
    public void Attack(){
        Debug.Log(this.power + "のダメージを与えた");
    }
    //防御用の関数
    public void Defence(int damage){
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
       
    }
    
//発展課題　　魔法攻撃をするMagic関数
    public void Magic(int shouhi){
        
        if (mp >= shouhi){
           this.mp -= shouhi;
            Debug.Log("魔法攻撃をした。残りＭＰは" + mp + "です。");
        } else{
            Debug.Log("ＭＰが足りない！！");
        }

    }
   
}
