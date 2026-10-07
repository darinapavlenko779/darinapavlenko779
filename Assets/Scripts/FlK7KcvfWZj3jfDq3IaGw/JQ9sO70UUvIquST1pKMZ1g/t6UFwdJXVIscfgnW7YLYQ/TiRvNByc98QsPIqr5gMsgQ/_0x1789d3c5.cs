using UnityEngine;
using UnityEngine.UI;

public class _0x1789d3c5 : MonoBehaviour
{
    private Button _0xa0c4d934;
    private void Awake()
    {
        if (this._0xa0c4d934 == null)
            if (!this.TryGetComponent(out this._0xa0c4d934))
                this._0xa0c4d934 = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this._0xed451f51)
            this._0xa0c4d934.onClick.AddListener(() => _0x7ed5945d.Instance._0x2d154569());
        else
            this._0xa0c4d934.onClick.AddListener(() => _0x7ed5945d.Instance._0xdfd1f132(this._0xfde20513));
    }

    private bool _0xed451f51;
    private int _0xfde20513;
}