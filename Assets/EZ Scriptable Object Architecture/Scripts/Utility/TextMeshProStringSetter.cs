using TMPro;
using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    public class TextMeshProStringSetter : MonoBehaviour
    {
        [SerializeField] private StringVariable stringVariable = default;
        [SerializeField] private TMP_Text text = default;

        private void Update()
        {
            text.text = stringVariable.Value;
        }
    }
}