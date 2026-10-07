using UnityEngine;
using UnityEngine.UI;

public class _0x07e59f94 : MonoBehaviour
{
    public bool IsPhysicsRunOnClick;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x940c8b68.Instance._0x775f3f6a(this.IsPhysicsRunOnClick));
    }
}