using UnityEngine;
using UnityEngine.UI;

namespace EZ.ScriptableObjectArchitecture
{
    public class ImageFillFloatSetter : MonoBehaviour
    {
        [SerializeField] private FloatVariable currentHp;
        [SerializeField] private FloatVariable maxHp;
        [SerializeField] private Image image;

        private void Update()
        {
            image.fillAmount = Mathf.Clamp01(currentHp / maxHp);
        }
    }
}
