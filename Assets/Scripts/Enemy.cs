using System;
using UnityEngine;
using UnityEngine.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;


public class Enemy : MonoBehaviour
{
    //цель, за которой должен двигаться персонаж
    [SerializeField] private Transform _player;
     private float _currentTime;
    //скорость следования
    [SerializeField] private float _speed =1;
   

    private void Start()
    {
        //ищем нашего персонажа
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    //метод преследования
    private void FixedUpdate()
    {
        transform.LookAt(_player);
        _currentTime = Time.deltaTime;
        var progress = _currentTime *_speed ;
        transform.position = Vector3.Lerp(transform.position,  _player.position, progress);
    }
    
    
}