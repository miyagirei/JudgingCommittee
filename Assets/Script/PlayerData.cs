using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�ő�̗�")]
    public float maxStamina;

    [SerializeField]
    [Tooltip("�ő�{��Q�[�W")]
    public float maxStress;
    
    public static float money;
}
