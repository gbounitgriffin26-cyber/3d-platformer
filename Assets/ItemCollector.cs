using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;

    [SerializeField] TextMeshProUGUI coinsText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
        }
    }
}
