using UnityEngine;
using UnityEngine.UI;

namespace EZ.ScriptableObjectArchitecture
{
    public class ImageFillFloatSetter : MonoBehaviour
    {
        [SerializeField] private FloatVariable currentHp = default;
        [SerializeField] private FloatVariable maxHp = default;
        [SerializeField] private Image image = default;

        private void Update()
        {
            image.fillAmount = Mathf.Clamp01(currentHp / maxHp);
        }
    }
}
