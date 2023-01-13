using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class EnemyDestroy : MonoBehaviour
{
    //поле с префабом пули
    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private UnityEvent _onDestroy;
    
    //когда пуля встречается с врагом, то уничтожает себя и врага
    private void OnCollisionEnter(Collision collision)
    {
        _rigidbody.useGravity = true;
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        _onDestroy.Invoke();
    }
}
