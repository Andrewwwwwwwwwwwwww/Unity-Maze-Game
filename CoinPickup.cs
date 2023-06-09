using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CoinPickup : MonoBehaviour
{
    public int currentCoin = 1;
    public int totalValue = 0;

    private Dictionary<string, int> coinValues = new Dictionary<string, int>();


    void Start()
    {
        coinValues.Add("gold", 10);
        coinValues.Add("silver", 5);
        coinValues.Add("bronze", 2);
        ScoreText.text = ("Score: " + score).ToString();
    }

    int score = 0;
    public TextMeshProUGUI ScoreText;

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("hit coin");
        if (other.gameObject.tag == "Coin")
        {
            string coinType = other.gameObject.name.ToLower();

            if (coinValues.ContainsKey(coinType))
            {
                currentCoin = coinValues[coinType];
                score += currentCoin;
                ScoreText.text = ("Score: " + score).ToString();
            }
            totalValue += currentCoin;
            Debug.Log("Coin Value: " + totalValue);
            Destroy(other.gameObject);
        }

    }
}
