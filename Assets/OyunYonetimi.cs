using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunYonetimi : MonoBehaviour
{
    public static OyunYonetimi instance; // Singleton instance

    #region playervsai

    private int DusmanPuanPlavyervsAI ;
    private int PlayerPuanPlayvervsAI ;// Skor tutucu
    public Text PlayerPuanTextPlayvervsAI;
    public Text DusmanPuanTextPlayvervsAI;

    #endregion

    #region aivsai

    private int DusmanPuanAIvsAI ;
    private int PlayerPuanAIvsAI ;// Skor tutucu
    public Text PlayerPuanTextAIvsAI;
    public Text DusmanPuanTextAIvsAI;
    

    #endregion
   
    
    
    
    

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
           // DontDestroyOnLoad(gameObject); // Script'i sahne değişimlerinde yok etme
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {

        #region playervsai

        DusmanPuanPlavyervsAI = PlayerPrefs.GetInt("DusmanPuanPlavyervsAI");
        PlayerPuanPlayvervsAI = PlayerPrefs.GetInt("PlayerPuanPlayvervsAI");

        #endregion

        #region aivsai

        DusmanPuanAIvsAI = PlayerPrefs.GetInt("DusmanPuanAIvsAI");
        PlayerPuanAIvsAI = PlayerPrefs.GetInt("PlayerPuanAIvsAI");

        #endregion
       
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "playervsai")
        {
            // Oyun sahnesindeyse, puanı ekranda göster
            GuncellePuanTextPlayvervsAI();
        }

        if (SceneManager.GetActiveScene().name == "aivsai")
        {
            GuncellePuanTextAIvsAI();
        }
    }





    #region playervsai

    

    
    public void PlayerPuanEkle(int miktar)
    {
        // Puan ekleme fonksiyonu
        PlayerPuanPlayvervsAI += miktar;
        GuncellePuanTextPlayvervsAI();
        PlayerPrefs.SetInt("PlayerPuanPlayvervsAI",PlayerPuanPlayvervsAI);
    }
    public void DusmanPuanEkle(int miktar)
    {
        // Puan ekleme fonksiyonu
        DusmanPuanPlavyervsAI += miktar;
        GuncellePuanTextPlayvervsAI();
        PlayerPrefs.SetInt("DusmanPuanPlavyervsAI",DusmanPuanPlavyervsAI);
    }

    void GuncellePuanTextPlayvervsAI()
    {
        // Puanı ekranda göster
        PlayerPuanTextPlayvervsAI.text = "Puan: " + PlayerPuanPlayvervsAI.ToString();
        DusmanPuanTextPlayvervsAI.text = "Puan: " + DusmanPuanPlavyervsAI.ToString();
    }

    #endregion
    
    
    #region aivsai
    
    public void PlayerAIPuanEkle(int miktar)
    {
        // Puan ekleme fonksiyonu
        PlayerPuanAIvsAI += miktar;
        GuncellePuanTextAIvsAI();
        PlayerPrefs.SetInt("PlayerPuanAIvsAI",PlayerPuanAIvsAI);
    }
    
    public void DusmanAIPuanEkle(int miktar)
    {
        // Puan ekleme fonksiyonu
        DusmanPuanAIvsAI += miktar;
        GuncellePuanTextAIvsAI();
        PlayerPrefs.SetInt("DusmanPuanAIvsAI",DusmanPuanAIvsAI);
    }
    
    void GuncellePuanTextAIvsAI()
    {
        // Puanı ekranda göster
        PlayerPuanTextAIvsAI.text = "Puan: " + PlayerPuanAIvsAI.ToString();
        DusmanPuanTextAIvsAI.text = "Puan: " + DusmanPuanAIvsAI.ToString();
    }
    
    #endregion
    
    
}