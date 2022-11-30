using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plater : MonoBehaviour
{
    //�������� ������
    private int health = 10;

    //������ �������� ���� � ��������� ����� �����
    public GameObject fireballPrefab;
    public Transform attackPoint;

    private int health = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
     public void TakeDamage(int damage)
    {
        health -= damage;
        print("�������� ������:" + health);
    }
}
