using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform player;     // Refer�ncia ao personagem
    public Vector3 offset;       // Dist�ncia entre a c�mera e o player
    public float smoothSpeed = 0.125f; // Suavidade do movimento

    void LateUpdate()
    {
        if (player == null) return;

        // Posi��o desejada da c�mera
        Vector3 desiredPosition = player.position + offset;

        // Suavizar o movimento at� a posi��o desejada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

        // Faz a c�mera olhar para o player (opcional)
        transform.LookAt(player);
    }
}

