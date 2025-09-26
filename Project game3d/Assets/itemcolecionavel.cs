using UnityEngine;

public class itemcolecionavel : MonoBehaviour
{
 
    public int valor = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Gamemaneger.pontuacao += valor;
            Destroy(gameObject);
        }
    }
}


