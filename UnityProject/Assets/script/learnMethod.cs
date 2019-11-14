using UnityEngine;

public class learnMethod : MonoBehaviour
{
    //定義方法
    //自行定義功能
    //語法:
    //修飾詞 傳回類型 名稱(參數1類型 參數1名稱,參數2類型 參數2名稱,...... ){陳述式或演算法}
    //傳回類型
    //可以是任何類型或無傳回
    //void=不傳回
    /// <summary>
    /// 踩油門
    /// </summary>
    private void Drive()
    {
        print("油門催下去，紅燈不要停");
    }
    //單一次呼叫事件
 
    private void Start()
    {
        Drive();
    }
    
}
