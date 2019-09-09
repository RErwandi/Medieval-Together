using TMPro;
using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    public class TextMeshProIntSetter : MonoBehaviour
    {
        [SerializeField] private IntVariable intVariable;
        [SerializeField] private TMP_Text text;

        private void Update()
        {
            text.text = intVariable.ToString();
        }
    }
}