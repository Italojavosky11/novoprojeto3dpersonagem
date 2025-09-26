using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform player;     // Referência ao personagem
    public Vector3 offset;       // Distância entre a câmera e o player
    public float smoothSpeed = 0.125f; // Suavidade do movimento

    void LateUpdate()
    {
        if (player == null) return;

        // Posição desejada da câmera
        Vector3 desiredPosition = player.position + offset;

        // Suavizar o movimento até a posição desejada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

        // Faz a câmera olhar para o player (opcional)
        transform.LookAt(player);
    }
}

