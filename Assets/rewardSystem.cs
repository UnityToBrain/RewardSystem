using System;
using TMPro;
using UnityEngine;

public class rewardSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI rewardToShow;
    [SerializeField] private Transform Hand;
    [SerializeField] private Animator handAnim;
    void Start()
    {
        handAnim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("rewardNo"))
        {
            var multiplier = other.gameObject.name;

            rewardToShow.text = (500 * float.Parse(multiplier)).ToString();
            PlayerPrefs.SetFloat("reward",float.Parse( rewardToShow.text));
        }
    }

    public void GetTheReward()
    {
        CoinReward.CoinRewardInstance.CountCoins();
        handAnim.enabled = false;
    }
}
