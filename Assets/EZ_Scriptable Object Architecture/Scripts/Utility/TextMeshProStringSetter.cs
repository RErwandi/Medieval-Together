using TMPro;
using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    public class TextMeshProStringSetter : MonoBehaviour
    {
        [SerializeField] private StringVariable stringVariable;
        [SerializeField] private TMP_Text text;

        private void Update()
        {
            text.text = stringVariable.Value;
        }
    }
}