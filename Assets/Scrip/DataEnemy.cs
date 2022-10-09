using UnityEngine;

[CreateAssetMenu(menuName = "GameDataSetting/Enemy", fileName = "dataEnemy")]

public class DataEnemy : ScriptableObject
{
    [Header("¨¤¦â¼Æ­È")]
    public float Health = 100;
    public float Attack = 10;
    [Range(0.1f,15)]public float movementSpeed = 15;

    [Header("§ðÀ»°Ï°ì")]
    public Color attackAreaColor = new Color(0, 1, 0.2f, 0.7f);
    public Vector3 attackAreaSize = Vector3.one;
    public Vector3 attackAreaOffset;

    [Header("§ðÀ»½d³ò")]
    public Color attackRangeColor = new Color(0, 1, 0, 0.5f);
    [Range(0, 5)] public float attackRange = 2f;

    [Header("§ðÀ»AI°»´ú")]
    public Color checkTargetColor = new Color(1, 0.1f, 0.1f, 0.3f);
    public Vector3 checkTargetArea = Vector3.one;
    public Vector3 checkTargetOffset;
    public LayerMask whitchIsTarget;

    [Header("¦aªOAI°»´ú")]
    public Color groundCheckColor = new Color(1,0.5f,0.3f,0.3f);
    public Vector3 groundCheckArea = Vector3.one;
    public Vector3 groundCheckOffset;
    public LayerMask whichIsGround;


}
