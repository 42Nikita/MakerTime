using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
     public int coinValue = 1; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Coin.Instance.AddCoins(coinValue);
            Destroy(gameObject); 
        }
    }
    public static Coin Instance;

    public TextMeshProUGUI coinText;  
    private int coinCount = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        UpdateCoinUI();
    }

    public void AddCoins(int amount)
    {
        coinCount += amount;
        UpdateCoinUI();
    }

    private void UpdateCoinUI()
    {
        if (coinText != null)
            coinText.text = "Coins: " + coinCount;
    }
}
