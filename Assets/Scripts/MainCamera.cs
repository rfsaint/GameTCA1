using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform target;  // O jogador ou objeto que a c�mera deve seguir
    public float smoothSpeed = 7.5f;  // A velocidade suave de movimento da c�mera

    private Vector3 offset;  // A dist�ncia entre a c�mera e o jogador no in�cio

    public float minX = 41.18f;
    public float maxX = -1.07f;
    public float minY = -9.48f;
    public float maxY = 4.3f;
    void Start()
    {
        // Calcula o deslocamento inicial entre a c�mera e o jogador
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        // Calcula a nova posi��o da c�mera suavemente
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;


    }
}