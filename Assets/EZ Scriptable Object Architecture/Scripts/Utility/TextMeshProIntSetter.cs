using TMPro;
using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    public class TextMeshProIntSetter : MonoBehaviour
    {
        [SerializeField] private IntVariable intVariable = default;
        [SerializeField] private TMP_Text text = default;

        private void Update()
        {
            text.text = intVariable.ToString();
        }
    }
}