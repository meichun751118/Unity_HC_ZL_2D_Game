using UnityEngine;

public class gg : MonoBehaviour
{
    [Header("血量")]
    [Range(1, 999)]
    public int 血量;
    [Header("移動速度")]
    [Range(0, 15)]
    public float speed = 1.5f;
    [Header("跳躍力道")]
    [Range(1, 200)]
    public float jump = 2;
    [Header("是否死亡")]
    [Tooltip("打勾為死亡")]
    public bool dead = false;
}
