using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagle : MonoBehaviour
{
    Vector3 pos; //������ġ

    float delta = 1.0f; // ���Ϸ� �̵������� (y)�ִ밪

    float speed = 3.0f; // �̵��ӵ�




    void Start()
    {

        pos = transform.position;

    }


    void Update()
    {

        Vector3 v = pos;

        v.y += delta * Mathf.Sin(Time.time * speed);

        // ���� �̵��� �ִ�ġ �� ���� ó��

        transform.position = v;

    }


}
