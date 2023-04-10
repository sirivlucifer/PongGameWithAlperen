using System;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes
{
    public class UI : MonoBehaviour
    {
        public Text puanText;
        private int oyuncuPuan;
        private int dusmanPuan;

        private void Start()
        {
            oyuncuPuan = 0;
            dusmanPuan = 0;
        }
        
        
    }
    
    
}