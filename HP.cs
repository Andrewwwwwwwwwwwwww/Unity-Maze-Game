using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class HP : MonoBehaviour
{

    private void Awake()
    {
        HPText.text = ("HP: " + hp).ToString();
    }


    int hp = 10;
    public TextMeshProUGUI HPText;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Floor" || other.gameObject.tag == "Coin")
        {
            return;
        }
        else
        {
            hp--;
            HPText.text = ("HP: " + hp).ToString();
        }

    }

}
