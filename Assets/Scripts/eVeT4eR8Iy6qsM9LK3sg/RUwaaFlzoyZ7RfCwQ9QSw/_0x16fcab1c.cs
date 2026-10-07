using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x16fcab1c : MonoBehaviour
{
    private void _0xfeccfdd8()
    {
        if (this._0x94170772.canvasRenderer.GetColor() != this._0x04ade9e4.canvasRenderer.GetColor())
            this._0x04ade9e4.canvasRenderer.SetColor(this._0x94170772.canvasRenderer.GetColor());
    }

    private Image _0x94170772;
    private TMP_Text _0x04ade9e4;
    private void Update()
    {
        this._0xfeccfdd8();
    }
}