using System.Collections.Generic;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class JAnkleL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JAnkleR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JEarL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JEarR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JElbowL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JElbowR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JEyeInnerL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JEyeInnerR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JEyeL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JEyeOuterL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JEyeOuterR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JEyeR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JFootIndexL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JFootIndexR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JHeelL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JHeelR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JHipL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JHipR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JIndexL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JIndexR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JKneeL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JKneeR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JMouthL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JMouthR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JNose
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JPinkyL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JPinkyR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JShoulderL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JShoulderR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JThumbL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JThumbR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JWristL
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JWristR
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
}

public class JsonPoseInformation
{
    public List<JAnkleL> J_ankle_L { get; set; }
    public List<JAnkleR> J_ankle_R { get; set; }
    public List<JEarL> J_ear_L { get; set; }
    public List<JEarR> J_ear_R { get; set; }
    public List<JElbowL> J_elbow_L { get; set; }
    public List<JElbowR> J_elbow_R { get; set; }
    public List<JEyeInnerL> J_eyeInner_L { get; set; }
    public List<JEyeInnerR> J_eyeInner_R { get; set; }
    public List<JEyeOuterL> J_eyeOuter_L { get; set; }
    public List<JEyeOuterR> J_eyeOuter_R { get; set; }
    public List<JEyeL> J_eye_L { get; set; }
    public List<JEyeR> J_eye_R { get; set; }
    public List<JFootIndexL> J_footIndex_L { get; set; }
    public List<JFootIndexR> J_footIndex_R { get; set; }
    public List<JHeelL> J_heel_L { get; set; }
    public List<JHeelR> J_heel_R { get; set; }
    public List<JHipL> J_hip_L { get; set; }
    public List<JHipR> J_hip_R { get; set; }
    public List<JIndexL> J_index_L { get; set; }
    public List<JIndexR> J_index_R { get; set; }
    public List<JKneeL> J_knee_L { get; set; }
    public List<JKneeR> J_knee_R { get; set; }
    public List<JMouthL> J_mouth_L { get; set; }
    public List<JMouthR> J_mouth_R { get; set; }
    public List<JNose> J_nose { get; set; }
    public List<JPinkyL> J_pinky_L { get; set; }
    public List<JPinkyR> J_pinky_R { get; set; }
    public List<JShoulderL> J_shoulder_L { get; set; }
    public List<JShoulderR> J_shoulder_R { get; set; }
    public List<JThumbL> J_thumb_L { get; set; }
    public List<JThumbR> J_thumb_R { get; set; }
    public List<JWristL> J_wrist_L { get; set; }
    public List<JWristR> J_wrist_R { get; set; }
    public List<double> frame_index { get; set; }
}

