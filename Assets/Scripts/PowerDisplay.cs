using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerDisplay : MonoBehaviour {

    private BallLauncher ballLauncher;
    [SerializeField]
    private Transform loadingBar;

    void Start()
    {
        ballLauncher = FindObjectOfType<BallLauncher>();
    }

    void Update()
    {
        float amount = (float)1/25*ballLauncher.speed;
        loadingBar.GetComponent<Image>().fillAmount = amount;
    }
}
