using TMPro;
using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    public class LocalizedString : MonoBehaviour, IGameEventListener
    {
        public TMP_Text text;
        public StringVariable idString;
        public StringVariable enString;
        public GameEvent swapLanguage;

        private void OnEnable()
        {
            swapLanguage.AddListener(this);
        }

        private void OnDisable()
        {
            swapLanguage.RemoveListener(this);
        }

        private void Start()
        {
            text.text = idString.Value;
        }

        private void SwapLanguage()
        {
            if (text.text == idString.Value)
            {
                text.text = enString.Value;
            }
            else
            {
                text.text = idString.Value;
            }
        }

        public void OnEventRaised()
        {
            SwapLanguage();
        }
    }
}