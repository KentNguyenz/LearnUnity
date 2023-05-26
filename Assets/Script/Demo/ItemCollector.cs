using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public delegate void CollectKiwies(int kiwies); //Dinh nghia ham delegate
    public static CollectKiwies collectKiwiesDelegate;// Khai bao ham delegate
    private int kiwies = 0;
    private void Start()
    {
        if(GameManager.Instance != null)
        {
            kiwies = GameManager.Instance.Kiwies;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kiwi"))
        {
            if (AudioManager.HasInstance)
            {
                AudioManager.Instance.PlaySE(AUDIO.SE_COLLECT);
            }
            kiwies++;
            
            if(GameManager.Instance != null)
            {
                GameManager.Instance.UpdateKiwies(kiwies);
            }
            collectKiwiesDelegate(kiwies);// phat su kien 
            Debug.Log("Kiwies:" + kiwies);
            Destroy(collision.gameObject);
        }
    }

}
