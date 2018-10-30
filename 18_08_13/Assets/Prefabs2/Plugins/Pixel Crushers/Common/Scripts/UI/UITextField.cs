﻿// Copyright © Pixel Crushers. All rights reserved.

using UnityEngine;
using System;

namespace PixelCrushers
{

    /// <summary>
    /// A UITextField can refer to a UI.Text or TMPro.TextMeshProUGUI.
    /// </summary>
    [Serializable]
    public class UITextField
    {

        [SerializeField]
        private UnityEngine.UI.Text m_uiText;

        /// <summary>
        /// The UI.Text assigned to this UI text field.
        /// </summary>
        public UnityEngine.UI.Text uiText
        {
            get { return m_uiText; }
            set { m_uiText = value; }
        }

#if TMP_PRESENT
        [SerializeField]
        private TMPro.TextMeshProUGUI m_textMeshProUGUI;

        /// <summary>
        /// The TextMeshProUGUI assigned to this UI text field.
        /// </summary>
        public TMPro.TextMeshProUGUI textMeshProUGUI
        {
            get { return m_textMeshProUGUI; }
            set { m_textMeshProUGUI = value; }
        }
#endif

        /// <summary>
        /// The text content of the UI.Text or TextMeshProUGUI.
        /// </summary>
        public string text
        {
            get
            {
#if TMP_PRESENT
                if (textMeshProUGUI != null) return textMeshProUGUI.text;
#endif
                if (uiText != null) return uiText.text;
                return string.Empty;
            }
            set
            {
#if TMP_PRESENT
                if (textMeshProUGUI != null) textMeshProUGUI.text = value;
#endif
                if (uiText != null) uiText.text = value;
            }
        }

        public bool enabled
        {
            get
            {
#if TMP_PRESENT
                if (textMeshProUGUI != null) return textMeshProUGUI.enabled;
#endif
                if (uiText != null) return uiText.enabled;
                return false;
            }
            set
            {
#if TMP_PRESENT
                if (textMeshProUGUI != null) textMeshProUGUI.enabled = value;
#endif
                if (uiText != null) uiText.enabled = value;
            }
        }

        public Color color
        {
            get
            {
#if TMP_PRESENT
                if (textMeshProUGUI != null) return textMeshProUGUI.color;
#endif
                if (uiText != null) return uiText.color;
                return Color.black;
            }
            set
            {
#if TMP_PRESENT
                if (textMeshProUGUI != null) textMeshProUGUI.color = value;
#endif
                if (uiText != null) uiText.color = value;
            }
        }

        public UITextField()
        {
            this.uiText = null;
#if TMP_PRESENT
            this.textMeshProUGUI = null;
#endif
        }

        public UITextField(UnityEngine.UI.Text uiText)
        {
            this.uiText = uiText;
#if TMP_PRESENT
            this.textMeshProUGUI = null;
#endif
        }

#if TMP_PRESENT
        public UITextField(TMPro.TextMeshProUGUI textMeshProUGUI)
        {
            this.uiText = null;
            this.textMeshProUGUI = textMeshProUGUI;
        }
#endif

        public GameObject gameObject
        {
            get
            {
#if TMP_PRESENT
                if (textMeshProUGUI != null) return textMeshProUGUI.gameObject;
#endif
                return (uiText != null) ? uiText.gameObject : null;
            }
        }

        public bool isActiveSelf { get { return (gameObject != null) ? gameObject.activeSelf : false; } }

        public bool activeInHierarchy { get { return (gameObject != null) ? gameObject.activeInHierarchy: false; } }

        public void SetActive(bool value)
        {
            if (uiText != null) uiText.gameObject.SetActive(value);
#if TMP_PRESENT
            if (textMeshProUGUI != null) textMeshProUGUI.gameObject.SetActive(value);
#endif
        }

        /// <summary>
        /// Checks if a UI element is assigned to a UITextField.
        /// </summary>
        /// <param name="uiTextField">UITextField to check.</param>
        /// <returns>`true` if no UI element is assigned; otherwise `false`.</returns>
        public static bool IsNull(UITextField uiTextField)
        {
            if (uiTextField == null) return true;
            if (uiTextField.uiText != null) return false;
#if TMP_PRESENT
            if (uiTextField.textMeshProUGUI != null) return false;
#endif
            return true;
        }

    }
}
