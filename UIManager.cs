﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DillonsDream
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager instance;

        public Image blackScreen;
        public float fadeSpeed = 2f;
        public bool fadeToBlack, fadeFromBlack;

        public Text healthText;
        public Image healthImage;

        public Text coinText;
        // Start is called before the first frame update
        void Awake()
        {
            instance = this;
        }

        // Update is called once per frame
        void Update()
        {
            if (fadeToBlack)
            {
                blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 1f, fadeSpeed * Time.deltaTime));
                if (blackScreen.color.a == 1f)
                {
                    fadeToBlack = false;
                }
            }

            if (fadeFromBlack)
            {
                blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 0f, fadeSpeed * Time.deltaTime));
                if (blackScreen.color.a == 0f)
                {
                    fadeFromBlack = false;
                }
            }
        }
    }

}
