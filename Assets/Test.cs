using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int hp = 100;
    int power = 25;

    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");

        this.hp -= damage;
    }
}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 1, 5, 100,25,75 };

        Debug.Log("���Ԃɕ\��");
        for(int i = 0;i< array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        Debug.Log("�t���ɕ\��");
        for (int i = array.Length-1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
