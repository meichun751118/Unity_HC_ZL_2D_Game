using UnityEngine;

public class first : MonoBehaviour
{
 
    [Header("血量")]
    [Range(1, 999)]
    public int 血量;
    public float speed = 1.5f;
    [Header("攻擊力")]
    [Range(0, 9999)]
    public int 攻擊力;
}
