using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField]
    [Tooltip("最大体力")]
    public float maxStamina;

    [SerializeField]
    [Tooltip("最大怒りゲージ")]
    public float maxStress;
    
    public static float money;
}
