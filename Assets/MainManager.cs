using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using JetBrains.Annotations;
using System.Runtime.CompilerServices;

public class MainManager : MonoBehaviour
{
    JsonPoseInformation jsonData;
    private int id = 0;
    private float id_float = 0;
    private float gizmosSize = 0.02f;

    private void Awake()
    {
        jsonData = JsonConvert.DeserializeObject<JsonPoseInformation>(File.ReadAllText("Assets/pose_3D_input_video.json"));
    }

    void OnDrawGizmos()
    {
        if (id < jsonData.J_ankle_L.Count)
        {
            // StartCoroutine(DelayTime(0.05f));
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_ankle_L[id].x, (float)jsonData.J_ankle_L[id].y, (float)jsonData.J_ankle_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_ankle_R[id].x, (float)jsonData.J_ankle_R[id].y, (float)jsonData.J_ankle_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_ear_L[id].x, (float)jsonData.J_ear_L[id].y, (float)jsonData.J_ear_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_ear_R[id].x, (float)jsonData.J_ear_R[id].y, (float)jsonData.J_ear_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_elbow_L[id].x, (float)jsonData.J_elbow_L[id].y, (float)jsonData.J_elbow_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_elbow_R[id].x, (float)jsonData.J_elbow_R[id].y, (float)jsonData.J_elbow_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_eyeInner_L[id].x, (float)jsonData.J_eyeInner_L[id].y, (float)jsonData.J_eyeInner_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_eyeInner_R[id].x, (float)jsonData.J_eyeInner_R[id].y, (float)jsonData.J_eyeInner_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_eyeOuter_L[id].x, (float)jsonData.J_eyeOuter_L[id].y, (float)jsonData.J_eyeOuter_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_eyeOuter_R[id].x, (float)jsonData.J_eyeOuter_R[id].y, (float)jsonData.J_eyeOuter_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_eye_L[id].x, (float)jsonData.J_eye_L[id].y, (float)jsonData.J_eye_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_eye_R[id].x, (float)jsonData.J_eye_R[id].y, (float)jsonData.J_eye_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_footIndex_L[id].x, (float)jsonData.J_footIndex_L[id].y, (float)jsonData.J_footIndex_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_footIndex_R[id].x, (float)jsonData.J_footIndex_R[id].y, (float)jsonData.J_footIndex_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_heel_L[id].x, (float)jsonData.J_heel_L[id].y, (float)jsonData.J_heel_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_hip_L[id].x, (float)jsonData.J_hip_L[id].y, (float)jsonData.J_hip_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_hip_R[id].x, (float)jsonData.J_hip_R[id].y, (float)jsonData.J_hip_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_index_L[id].x, (float)jsonData.J_index_L[id].y, (float)jsonData.J_index_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_index_R[id].x, (float)jsonData.J_index_R[id].y, (float)jsonData.J_index_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_knee_L[id].x, (float)jsonData.J_knee_L[id].y, (float)jsonData.J_knee_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_knee_R[id].x, (float)jsonData.J_knee_R[id].y, (float)jsonData.J_knee_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_mouth_L[id].x, (float)jsonData.J_mouth_L[id].y, (float)jsonData.J_mouth_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_mouth_R[id].x, (float)jsonData.J_mouth_R[id].y, (float)jsonData.J_mouth_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_nose[id].x, (float)jsonData.J_nose[id].y, (float)jsonData.J_nose[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_pinky_L[id].x, (float)jsonData.J_pinky_L[id].y, (float)jsonData.J_pinky_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_pinky_R[id].x, (float)jsonData.J_pinky_R[id].y, (float)jsonData.J_pinky_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_shoulder_L[id].x, (float)jsonData.J_shoulder_L[id].y, (float)jsonData.J_shoulder_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_shoulder_R[id].x, (float)jsonData.J_shoulder_R[id].y, (float)jsonData.J_shoulder_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_thumb_L[id].x, (float)jsonData.J_thumb_L[id].y, (float)jsonData.J_thumb_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_thumb_R[id].x, (float)jsonData.J_thumb_R[id].y, (float)jsonData.J_thumb_R[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_wrist_L[id].x, (float)jsonData.J_wrist_L[id].y, (float)jsonData.J_wrist_L[id].z), gizmosSize);
            Gizmos.DrawSphere(new Vector3((float)jsonData.J_wrist_R[id].x, (float)jsonData.J_wrist_R[id].y, (float)jsonData.J_wrist_R[id].z), gizmosSize);

            id_float += 0.05f;
            id = Mathf.RoundToInt(id_float);
        }
        else
        {
            id = 0;
            id_float = 0;
        }
    }

    private bool isWaiting = false;
    private IEnumerator DelayTime(float time)
    {
        isWaiting = true;
        yield return new WaitForSeconds(time);
        isWaiting = false;
    }
}
