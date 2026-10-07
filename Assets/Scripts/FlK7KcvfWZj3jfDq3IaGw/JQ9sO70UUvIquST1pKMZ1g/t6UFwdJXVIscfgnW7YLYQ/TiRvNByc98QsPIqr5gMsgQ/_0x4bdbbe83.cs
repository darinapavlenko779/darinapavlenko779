using UnityEngine;
using UnityEngine.UI;

public class _0x4bdbbe83 : MonoBehaviour
{
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x7b505880.Instance._0x06270661();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x7b505880.Instance._0xa077288f());
        else
            this.Button.onClick.AddListener(() => _0x7b505880.Instance._0xc011989b(this.PopToShowIndex));
    }

    public int PopToShowIndex;
    public bool IsHideAllPops;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsShowLastPop;
    public Button Button;
}