using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnEnemy : MonoBehaviour
{
    //сериализуем поля "враг" и канвас, который показывает иконки с врагами
    [SerializeField] private GameObject _enemy;
    
    [SerializeField] private PlayerCanvas _canvas;
    
    [SerializeField] public int countEnemys=5;
   
    //на старте добавляем иконки и инициализуем врагов
    void Start()
    {
        _canvas.AddIcon();
        for (int i=0;i<countEnemys;i++)
        {
            var enemy = Instantiate(_enemy);//спавним нового врага
            enemy.transform.position = new Vector3( Random.Range(-20,20),1,Random.Range(-20,20));
            _canvas.AddIcon();
        }
    }
}