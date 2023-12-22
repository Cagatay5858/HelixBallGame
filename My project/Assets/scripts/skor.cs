using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skor : MonoBehaviour
{
    [SerializeField]
    private Button button;
    [SerializeField]
    private TextMeshProUGUI state_text;
    [SerializeField]
    private TextMeshProUGUI score_text;
    private int point = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //en optimize þekli compare tag
        if (other.gameObject.CompareTag("Skor"))
        {
            point++;
            score_text.text = "Skor : " + point.ToString();
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Yanma"))
        {
            state_text.text = "Oyunu Kaybettin";
            
            Time.timeScale = 0;
            button.gameObject.SetActive(true);


        }
        if (collision.gameObject.CompareTag("Bitis"))
        {
            state_text.text = "Oyunu Kazandýn";
            
            Time.timeScale = 0;
            button.gameObject.SetActive(true);


        }
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//oyun sahnemizi getir ve build et
    }
}
