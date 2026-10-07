using TMPro;
using UnityEngine;
using static _0x3beca35c;

public class _0x72c47f94 : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    public void _0xdf934737()
    {
        this.MoneyCountText.text = _0x8454d6c6._0xa94e5651.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x24e302a2;
            if (this.gameObject.TryGetComponent(out _0x24e302a2))
                this.MoneyCountText = _0x24e302a2;
        }

        this._0xdf934737();
    }
}