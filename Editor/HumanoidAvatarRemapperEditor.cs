using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(HumanoidAvatarRemapper))]
public class HumanoidAvatarRemapperEditor : Editor
{
    SerializedProperty m_Avatar;
    SerializedProperty m_BaseAvatar;
    SerializedProperty m_HipsHeightOffset;
    SerializedProperty m_Root;

    SerializedProperty m_hips;
    SerializedProperty m_leftUpperLeg;
    SerializedProperty m_rightUpperLeg;
    SerializedProperty m_leftLowerLeg;
    SerializedProperty m_rightLowerLeg;
    SerializedProperty m_leftFoot;
    SerializedProperty m_rightFoot;
    SerializedProperty m_spine;
    SerializedProperty m_chest;
    SerializedProperty m_neck;
    SerializedProperty m_head;
    SerializedProperty m_leftShoulder;
    SerializedProperty m_rightShoulder;
    SerializedProperty m_leftUpperArm;
    SerializedProperty m_rightUpperArm;
    SerializedProperty m_leftLowerArm;
    SerializedProperty m_rightLowerArm;
    SerializedProperty m_leftHand;
    SerializedProperty m_rightHand;
    SerializedProperty m_leftToes;
    SerializedProperty m_rightToes;
    SerializedProperty m_leftEye;
    SerializedProperty m_rightEye;
    SerializedProperty m_jaw;
    SerializedProperty m_leftThumbProximal;
    SerializedProperty m_leftThumbIntermediate;
    SerializedProperty m_leftThumbDistal;
    SerializedProperty m_leftIndexProximal;
    SerializedProperty m_leftIndexIntermediate;
    SerializedProperty m_leftIndexDistal;
    SerializedProperty m_leftMiddleProximal;
    SerializedProperty m_leftMiddleIntermediate;
    SerializedProperty m_leftMiddleDistal;
    SerializedProperty m_leftRingProximal;
    SerializedProperty m_leftRingIntermediate;
    SerializedProperty m_leftRingDistal;
    SerializedProperty m_leftLittleProximal;
    SerializedProperty m_leftLittleIntermediate;
    SerializedProperty m_leftLittleDistal;
    SerializedProperty m_rightThumbProximal;
    SerializedProperty m_rightThumbIntermediate;
    SerializedProperty m_rightThumbDistal;
    SerializedProperty m_rightIndexProximal;
    SerializedProperty m_rightIndexIntermediate;
    SerializedProperty m_rightIndexDistal;
    SerializedProperty m_rightMiddleProximal;
    SerializedProperty m_rightMiddleIntermediate;
    SerializedProperty m_rightMiddleDistal;
    SerializedProperty m_rightRingProximal;
    SerializedProperty m_rightRingIntermediate;
    SerializedProperty m_rightRingDistal;
    SerializedProperty m_rightLittleProximal;
    SerializedProperty m_rightLittleIntermediate;
    SerializedProperty m_rightLittleDistal;
    SerializedProperty m_upperChest;

    void OnEnable()
    {
        m_Avatar = serializedObject.FindProperty("_avatar");
        m_BaseAvatar = serializedObject.FindProperty("_baseAvatar");
        m_HipsHeightOffset = serializedObject.FindProperty("_hipsHeightOffset");
        m_Root = serializedObject.FindProperty("_root");

        m_hips = serializedObject.FindProperty("_hips");
        m_leftUpperLeg = serializedObject.FindProperty("_leftUpperLeg");
        m_rightUpperLeg = serializedObject.FindProperty("_rightUpperLeg");
        m_leftLowerLeg = serializedObject.FindProperty("_leftLowerLeg");
        m_rightLowerLeg = serializedObject.FindProperty("_rightLowerLeg");
        m_leftFoot = serializedObject.FindProperty("_leftFoot");
        m_rightFoot = serializedObject.FindProperty("_rightFoot");
        m_spine = serializedObject.FindProperty("_spine");
        m_chest = serializedObject.FindProperty("_chest");
        m_neck = serializedObject.FindProperty("_neck");
        m_head = serializedObject.FindProperty("_head");
        m_leftShoulder = serializedObject.FindProperty("_leftShoulder");
        m_rightShoulder = serializedObject.FindProperty("_rightShoulder");
        m_leftUpperArm = serializedObject.FindProperty("_leftUpperArm");
        m_rightUpperArm = serializedObject.FindProperty("_rightUpperArm");
        m_leftLowerArm = serializedObject.FindProperty("_leftLowerArm");
        m_rightLowerArm = serializedObject.FindProperty("_rightLowerArm");
        m_leftHand = serializedObject.FindProperty("_leftHand");
        m_rightHand = serializedObject.FindProperty("_rightHand");
        m_leftToes = serializedObject.FindProperty("_leftToes");
        m_rightToes = serializedObject.FindProperty("_rightToes");
        m_leftEye = serializedObject.FindProperty("_leftEye");
        m_rightEye = serializedObject.FindProperty("_rightEye");
        m_jaw = serializedObject.FindProperty("_jaw");
        m_leftThumbProximal = serializedObject.FindProperty("_leftThumbProximal");
        m_leftThumbIntermediate = serializedObject.FindProperty("_leftThumbIntermediate");
        m_leftThumbDistal = serializedObject.FindProperty("_leftThumbDistal");
        m_leftIndexProximal = serializedObject.FindProperty("_leftIndexProximal");
        m_leftIndexIntermediate = serializedObject.FindProperty("_leftIndexIntermediate");
        m_leftIndexDistal = serializedObject.FindProperty("_leftIndexDistal");
        m_leftMiddleProximal = serializedObject.FindProperty("_leftMiddleProximal");
        m_leftMiddleIntermediate = serializedObject.FindProperty("_leftMiddleIntermediate");
        m_leftMiddleDistal = serializedObject.FindProperty("_leftMiddleDistal");
        m_leftRingProximal = serializedObject.FindProperty("_leftRingProximal");
        m_leftRingIntermediate = serializedObject.FindProperty("_leftRingIntermediate");
        m_leftRingDistal = serializedObject.FindProperty("_leftRingDistal");
        m_leftLittleProximal = serializedObject.FindProperty("_leftLittleProximal");
        m_leftLittleIntermediate = serializedObject.FindProperty("_leftLittleIntermediate");
        m_leftLittleDistal = serializedObject.FindProperty("_leftLittleDistal");
        m_rightThumbProximal = serializedObject.FindProperty("_rightThumbProximal");
        m_rightThumbIntermediate = serializedObject.FindProperty("_rightThumbIntermediate");
        m_rightThumbDistal = serializedObject.FindProperty("_rightThumbDistal");
        m_rightIndexProximal = serializedObject.FindProperty("_rightIndexProximal");
        m_rightIndexIntermediate = serializedObject.FindProperty("_rightIndexIntermediate");
        m_rightIndexDistal = serializedObject.FindProperty("_rightIndexDistal");
        m_rightMiddleProximal = serializedObject.FindProperty("_rightMiddleProximal");
        m_rightMiddleIntermediate = serializedObject.FindProperty("_rightMiddleIntermediate");
        m_rightMiddleDistal = serializedObject.FindProperty("_rightMiddleDistal");
        m_rightRingProximal = serializedObject.FindProperty("_rightRingProximal");
        m_rightRingIntermediate = serializedObject.FindProperty("_rightRingIntermediate");
        m_rightRingDistal = serializedObject.FindProperty("_rightRingDistal");
        m_rightLittleProximal = serializedObject.FindProperty("_rightLittleProximal");
        m_rightLittleIntermediate = serializedObject.FindProperty("_rightLittleIntermediate");
        m_rightLittleDistal = serializedObject.FindProperty("_rightLittleDistal");
        m_upperChest = serializedObject.FindProperty("_upperChest");
    }

    bool foldBody = false;
    bool foldLeftLeg = false;
    bool foldRightLeg = false;
    bool foldLeftArm = false;
    bool foldRightArm = false;
    /// <summary>
    /// InspectorのGUIを更新
    /// </summary>
    public override void OnInspectorGUI()
    {
        //元のInspector部分を表示
        //base.OnInspectorGUI();

        //targetを変換して対象を取得
        HumanoidAvatarRemapper humanoidAvatarRemapper = target as HumanoidAvatarRemapper;
        
        EditorGUILayout.LabelField("改変するアバターのオブジェクト(指定必須)");
        EditorGUILayout.PropertyField(m_Avatar, new GUIContent("VRC Avatar Object"));
        EditorGUILayout.LabelField("　");
        EditorGUILayout.LabelField("ベースになるHumanoid Avatarの.assetファイル(任意)");
        EditorGUILayout.PropertyField(m_BaseAvatar, new GUIContent("Base Avatar asset"));
        EditorGUILayout.LabelField("　");
        EditorGUILayout.LabelField("足と床の高さのオフセット値（脚の長さを変更したときに使用）");
        EditorGUILayout.PropertyField(m_HipsHeightOffset, new GUIContent("HipsHeightOffset"));
        EditorGUILayout.LabelField("　");
        EditorGUILayout.LabelField("Hipsの親のオブジェクト(例：Armature)(任意）");
        EditorGUILayout.PropertyField(m_Root, new GUIContent("Root"));
        EditorGUILayout.LabelField("　");
        
        EditorGUILayout.LabelField("Humanoidの各部位に割り当てるオブジェクトを指定");
        foldBody = EditorGUILayout.Foldout(foldBody, "Body Bone");
        if(foldBody)
        {
        EditorGUILayout.PropertyField(m_hips, new GUIContent("hips"));
        EditorGUILayout.PropertyField(m_spine, new GUIContent("spine"));
        EditorGUILayout.PropertyField(m_upperChest, new GUIContent("upperChest"));
        EditorGUILayout.PropertyField(m_chest, new GUIContent("chest"));
        EditorGUILayout.PropertyField(m_neck, new GUIContent("neck"));
        EditorGUILayout.PropertyField(m_head, new GUIContent("head"));
        EditorGUILayout.PropertyField(m_leftEye, new GUIContent("leftEye"));
        EditorGUILayout.PropertyField(m_rightEye, new GUIContent("rightEye"));
        EditorGUILayout.PropertyField(m_jaw, new GUIContent("jaw"));
        }

        foldLeftLeg = EditorGUILayout.Foldout(foldLeftLeg, "LeftLeg Bone");
        if(foldLeftLeg)
        {
        EditorGUILayout.PropertyField(m_leftUpperLeg, new GUIContent("leftUpperLeg"));
        EditorGUILayout.PropertyField(m_leftLowerLeg, new GUIContent("leftLowerLeg"));
        EditorGUILayout.PropertyField(m_leftFoot, new GUIContent("leftFoot"));
        EditorGUILayout.PropertyField(m_leftToes, new GUIContent("leftToes"));
        }

        foldRightLeg = EditorGUILayout.Foldout(foldRightLeg, "Righteg Bone");
        if(foldRightLeg)
        {
        EditorGUILayout.PropertyField(m_rightUpperLeg, new GUIContent("rightUpperLeg"));
        EditorGUILayout.PropertyField(m_rightLowerLeg, new GUIContent("rightLowerLeg"));
        EditorGUILayout.PropertyField(m_rightFoot, new GUIContent("rightFoot"));
        EditorGUILayout.PropertyField(m_rightToes, new GUIContent("rightToes"));
        }

        foldLeftArm= EditorGUILayout.Foldout(foldLeftArm, "LeftArm Bone");
        if(foldLeftArm)
        {

        EditorGUILayout.PropertyField(m_leftShoulder, new GUIContent("leftShoulder"));
        EditorGUILayout.PropertyField(m_leftUpperArm, new GUIContent("leftUpperArm"));
        EditorGUILayout.PropertyField(m_leftLowerArm, new GUIContent("leftLowerArm"));
        EditorGUILayout.PropertyField(m_leftHand, new GUIContent("leftHand"));
        EditorGUILayout.PropertyField(m_leftThumbProximal, new GUIContent("left Thumb Proximal"));
        EditorGUILayout.PropertyField(m_leftThumbIntermediate, new GUIContent("left Thumb Intermediate"));
        EditorGUILayout.PropertyField(m_leftThumbDistal, new GUIContent("left Thumb Distal"));
        EditorGUILayout.PropertyField(m_leftIndexProximal, new GUIContent("left Index Proximal"));
        EditorGUILayout.PropertyField(m_leftIndexIntermediate, new GUIContent("left Index Intermediate"));
        EditorGUILayout.PropertyField(m_leftIndexDistal, new GUIContent("left Index Distal"));
        EditorGUILayout.PropertyField(m_leftMiddleProximal, new GUIContent("left Middle Proximal"));
        EditorGUILayout.PropertyField(m_leftMiddleIntermediate, new GUIContent("left Middle Intermediate"));
        EditorGUILayout.PropertyField(m_leftMiddleDistal, new GUIContent("left Middle Distal"));
        EditorGUILayout.PropertyField(m_leftRingProximal, new GUIContent("left Ring Proximal"));
        EditorGUILayout.PropertyField(m_leftRingIntermediate, new GUIContent("left Ring Intermediate"));
        EditorGUILayout.PropertyField(m_leftRingDistal, new GUIContent("left Ring Distal"));
        EditorGUILayout.PropertyField(m_leftLittleProximal, new GUIContent("left Little Proximal"));
        EditorGUILayout.PropertyField(m_leftLittleIntermediate, new GUIContent("left Little Intermediate"));
        EditorGUILayout.PropertyField(m_leftLittleDistal, new GUIContent("left Little Distal"));
        }

        foldRightArm= EditorGUILayout.Foldout(foldRightArm, "RightArm Bone");
        if(foldRightArm)
        {

        EditorGUILayout.PropertyField(m_rightShoulder, new GUIContent("rightShoulder"));
        EditorGUILayout.PropertyField(m_rightUpperArm, new GUIContent("rightUpperArm"));
        EditorGUILayout.PropertyField(m_rightLowerArm, new GUIContent("rightLowerArm"));
        EditorGUILayout.PropertyField(m_rightHand, new GUIContent("rightHand"));
        EditorGUILayout.PropertyField(m_rightThumbProximal, new GUIContent("right Thumb Proximal"));
        EditorGUILayout.PropertyField(m_rightThumbIntermediate, new GUIContent("right Thumb Intermediate"));
        EditorGUILayout.PropertyField(m_rightThumbDistal, new GUIContent("right Thumb Distal"));
        EditorGUILayout.PropertyField(m_rightIndexProximal, new GUIContent("right Index Proximal"));
        EditorGUILayout.PropertyField(m_rightIndexIntermediate, new GUIContent("right Index Intermediate"));
        EditorGUILayout.PropertyField(m_rightIndexDistal, new GUIContent("right Index Distal"));
        EditorGUILayout.PropertyField(m_rightMiddleProximal, new GUIContent("right Middle Proximal"));
        EditorGUILayout.PropertyField(m_rightMiddleIntermediate, new GUIContent("right Middle Intermediate"));
        EditorGUILayout.PropertyField(m_rightMiddleDistal, new GUIContent("right Middle Distal"));
        EditorGUILayout.PropertyField(m_rightRingProximal, new GUIContent("right Ring Proximal"));
        EditorGUILayout.PropertyField(m_rightRingIntermediate, new GUIContent("right Ring Intermediate"));
        EditorGUILayout.PropertyField(m_rightRingDistal, new GUIContent("right Ring Distal"));
        EditorGUILayout.PropertyField(m_rightLittleProximal, new GUIContent("right Little Proximal"));
        EditorGUILayout.PropertyField(m_rightLittleIntermediate, new GUIContent("right Little Intermediate"));
        EditorGUILayout.PropertyField(m_rightLittleDistal, new GUIContent("right Little Distal"));
        }
        serializedObject.ApplyModifiedProperties();

        EditorGUILayout.LabelField("");
        EditorGUILayout.LabelField("再割り当てしたAvatarの.assetをnyakomake/humanoidAvatarRemapper/以下に生成");
        //PublicMethodを実行する用のボタン
        if (GUILayout.Button("CreateRemapAvatar"))
        {
            humanoidAvatarRemapper.CreateRemapAvatar();
        }
        EditorGUILayout.LabelField("VRCDescripterのViewPosを自動的に設定(脚の長さを変更したときに使用）");
        if (GUILayout.Button("SetViewPosFromFootHeight"))
        {
            humanoidAvatarRemapper.SetViewPos();
        }
        if (GUILayout.Button("ResetViewPos"))
        {
            humanoidAvatarRemapper.RevertViewPos();
        }

    }
}
