using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartInitialize : MonoBehaviour
{
    [SerializeField]PlayerData playerData;
    public void DataInitialize()
    {
        playerData.maxStamina = 100;
        playerData.maxStress = 0;
        PlayerData.money = 0;
    }
}
