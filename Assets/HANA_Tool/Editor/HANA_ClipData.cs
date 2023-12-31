﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HANA_ClipDatas
{
    public class HANA_ClipData
    {
        public static readonly Dictionary<string, string> clipNameTable_VRoid = new Dictionary<string, string>()
        {
            {"BrowDownLeft",        "browDownLeft"},
            {"BrowDownRight",       "browDownRight"},
            {"BrowInnerUp",         "browInnerUp"},
            {"BrowOuterUpLeft",     "browOuterUpLeft"},
            {"BrowOuterUpRight",    "browOuterUpRight"},
            {"CheekPuff",           "cheekPuff"},
            {"CheekSquintLeft",     "cheekSquintLeft"},
            {"CheekSquintRight",    "cheekSquintRight"},
            {"EyeBlinkLeft",        "Fcl_EYE_Close_L"},
            {"EyeBlinkRight",       "Fcl_EYE_Close_R"},
            {"EyeLookDownLeft",     "eyeLookDownLeft"},
            {"EyeLookDownRight",    "eyeLookDownRight"},
            {"EyeLookInLeft",       "eyeLookInLeft"},
            {"EyeLookInRight",      "eyeLookInRight"},
            {"EyeLookOutLeft",      "eyeLookOutLeft"},
            {"EyeLookOutRight",     "eyeLookOutRight" },
            {"EyeLookUpLeft",       "eyeLookUpLeft"},
            {"EyeLookUpRight",      "eyeLookUpRight"},
            {"EyeSquintLeft",       "eyeSquintLeft"},
            {"EyeSquintRight",      "eyeSquintRight"},
            {"EyeWideLeft",         "eyeWideLeft"},
            {"EyeWideRight",        "eyeWideRight"},
            {"JawForward",          "jawForward"},
            {"JawLeft",             "jawLeft"},
            {"JawOpen",             "jawOpen"},
            {"JawRight",            "jawRight"},
            {"MouthClose",          "mouthClose"},
            {"MouthDimpleLeft",     "mouthDimpleLeft"},
            {"MouthDimpleRight",    "mouthDimpleRight"},
            {"MouthFrownLeft",      "mouthFrownLeft"},
            {"MouthFrownRight",     "mouthFrownRight"},
            {"MouthFunnel",         "mouthFunnel"},
            {"MouthLeft",           "mouthLeft"},
            {"MouthLowerDownLeft",  "mouthLowerDownLeft"},
            {"MouthLowerDownRight", "mouthLowerDownRight"},
            {"MouthPressLeft",      "mouthPressLeft"},
            {"MouthPressRight",     "mouthPressRight"},
            {"MouthPucker",         "mouthPucker"},
            {"MouthRight",          "mouthRight"},
            {"MouthRollLower",      "mouthRollLower"},
            {"MouthRollUpper",      "mouthRollUpper"},
            {"MouthShrugLower",     "mouthShrugLower"},
            {"MouthShrugUpper",     "mouthShrugUpper"},
            {"MouthSmileLeft",      "mouthSmileLeft"},
            {"MouthSmileRight",     "mouthSmileRight"},
            {"MouthStretchLeft",    "mouthStretchLeft"},
            {"MouthStretchRight",   "mouthStretchRight"},
            {"MouthUpperUpLeft",    "mouthUpperUpLeft"},
            {"MouthUpperUpRight",   "mouthUpperUpRight"},
            {"NoseSneerLeft",       "noseSneerLeft"},
            {"NoseSneerRight",      "noseSneerRight"},
            {"TongueOut",           "tongueOut"},
        };

        public static readonly Dictionary<string, string> clipNameTable_def = new Dictionary<string, string>()
        {
            {"BrowDownLeft",        "browDownLeft"},
            {"BrowDownRight",       "browDownRight"},
            {"BrowInnerUp",         "browInnerUp"},
            {"BrowOuterUpLeft",     "browOuterUpLeft"},
            {"BrowOuterUpRight",    "browOuterUpRight"},
            {"CheekPuff",           "cheekPuff"},
            {"CheekSquintLeft",     "cheekSquintLeft"},
            {"CheekSquintRight",    "cheekSquintRight"},
            {"EyeBlinkLeft",        "eyeBlinkLeft"},
            {"EyeBlinkRight",       "eyeBlinkRight"},
            {"EyeLookDownLeft",     "eyeLookDownLeft"},
            {"EyeLookDownRight",    "eyeLookDownRight"},
            {"EyeLookInLeft",       "eyeLookInLeft"},
            {"EyeLookInRight",      "eyeLookInRight"},
            {"EyeLookOutLeft",      "eyeLookOutLeft"},
            {"EyeLookOutRight",     "eyeLookOutRight" },
            {"EyeLookUpLeft",       "eyeLookUpLeft"},
            {"EyeLookUpRight",      "eyeLookUpRight"},
            {"EyeSquintLeft",       "eyeSquintLeft"},
            {"EyeSquintRight",      "eyeSquintRight"},
            {"EyeWideLeft",         "eyeWideLeft"},
            {"EyeWideRight",        "eyeWideRight"},
            {"JawForward",          "jawForward"},
            {"JawLeft",             "jawLeft"},
            {"JawOpen",             "jawOpen"},
            {"JawRight",            "jawRight"},
            {"MouthClose",          "mouthClose"},
            {"MouthDimpleLeft",     "mouthDimpleLeft"},
            {"MouthDimpleRight",    "mouthDimpleRight"},
            {"MouthFrownLeft",      "mouthFrownLeft"},
            {"MouthFrownRight",     "mouthFrownRight"},
            {"MouthFunnel",         "mouthFunnel"},
            {"MouthLeft",           "mouthLeft"},
            {"MouthLowerDownLeft",  "mouthLowerDownLeft"},
            {"MouthLowerDownRight", "mouthLowerDownRight"},
            {"MouthPressLeft",      "mouthPressLeft"},
            {"MouthPressRight",     "mouthPressRight"},
            {"MouthPucker",         "mouthPucker"},
            {"MouthRight",          "mouthRight"},
            {"MouthRollLower",      "mouthRollLower"},
            {"MouthRollUpper",      "mouthRollUpper"},
            {"MouthShrugLower",     "mouthShrugLower"},
            {"MouthShrugUpper",     "mouthShrugUpper"},
            {"MouthSmileLeft",      "mouthSmileLeft"},
            {"MouthSmileRight",     "mouthSmileRight"},
            {"MouthStretchLeft",    "mouthStretchLeft"},
            {"MouthStretchRight",   "mouthStretchRight"},
            {"MouthUpperUpLeft",    "mouthUpperUpLeft"},
            {"MouthUpperUpRight",   "mouthUpperUpRight"},
            {"NoseSneerLeft",       "noseSneerLeft"},
            {"NoseSneerRight",      "noseSneerRight"},
            {"TongueOut",           "tongueOut"},
        };

        public static readonly Dictionary<string, float> clipWeightTable_def = new Dictionary<string, float>()
        {
            {"BrowDownLeft",        100.0f },
            {"BrowDownRight",       100.0f },
            {"BrowInnerUp",         100.0f },
            {"BrowOuterUpLeft",     100.0f },
            {"BrowOuterUpRight",    100.0f },
            {"CheekPuff",           100.0f },
            {"CheekSquintLeft",     100.0f },
            {"CheekSquintRight",    100.0f },
            {"EyeBlinkLeft",        100.0f },
            {"EyeBlinkRight",       100.0f },
            {"EyeLookDownLeft",     100.0f },
            {"EyeLookDownRight",    100.0f },
            {"EyeLookInLeft",       100.0f },
            {"EyeLookInRight",      100.0f },
            {"EyeLookOutLeft",      100.0f },
            {"EyeLookOutRight",     100.0f },
            {"EyeLookUpLeft",       100.0f },
            {"EyeLookUpRight",      100.0f },
            {"EyeSquintLeft",       100.0f },
            {"EyeSquintRight",      100.0f },
            {"EyeWideLeft",         100.0f },
            {"EyeWideRight",        100.0f },
            {"JawForward",          100.0f },
            {"JawLeft",             100.0f },
            {"JawOpen",             100.0f },
            {"JawRight",            100.0f },
            {"MouthClose",          100.0f },
            {"MouthDimpleLeft",     100.0f },
            {"MouthDimpleRight",    100.0f },
            {"MouthFrownLeft",      100.0f },
            {"MouthFrownRight",     100.0f },
            {"MouthFunnel",         100.0f },
            {"MouthLeft",           100.0f },
            {"MouthLowerDownLeft",  100.0f },
            {"MouthLowerDownRight", 100.0f },
            {"MouthPressLeft",      100.0f },
            {"MouthPressRight",     100.0f },
            {"MouthPucker",         100.0f },
            {"MouthRight",          100.0f },
            {"MouthRollLower",      100.0f },
            {"MouthRollUpper",      100.0f },
            {"MouthShrugLower",     100.0f },
            {"MouthShrugUpper",     100.0f },
            {"MouthSmileLeft",      100.0f },
            {"MouthSmileRight",     100.0f },
            {"MouthStretchLeft",    100.0f },
            {"MouthStretchRight",   100.0f },
            {"MouthUpperUpLeft",    100.0f },
            {"MouthUpperUpRight",   100.0f },
            {"NoseSneerLeft",       100.0f },
            {"NoseSneerRight",      100.0f },
            {"TongueOut",           100.0f },
        };

        public static readonly Dictionary<string, string> clipNameTable_quest = new Dictionary<string, string>()
        {
            {"BrowLowererL",        "browLowererL"},
            {"BrowLowererR",        "browLowererR"},
            {"CheekPuffL",          "cheekPuffL"},
            {"CheekPuffR",          "cheekPuffR"},
            {"CheekRaiserL",        "cheekRaiserL"},
            {"CheekRaiserR",        "cheekRaiserR"},
            {"CheekSuckL",          "cheekSuckL"},
            {"CheekSuckR",          "cheekSuckR"},
            {"ChinRaiserB",         "chinRaiserB"},
            {"ChinRaiserT",         "chinRaiserT"},
            {"DimplerL",            "dimplerL"},
            {"DimplerR",            "dimplerR"},
            {"EyesClosedL",         "eyesClosedL"},
            {"EyesClosedR",         "eyesClosedR"},
            {"EyesLookDownL",       "eyesLookDownL"},
            {"EyesLookDownR",       "eyesLookDownR"},
            {"EyesLookLeftL",       "eyesLookLeftL"},
            {"EyesLookLeftR",       "eyesLookLeftR" },
            {"EyesLookRightL",      "eyesLookRightL"},
            {"EyesLookRightR",      "eyesLookRightR"},
            {"EyesLookUpL",         "eyesLookUpL"},
            {"EyesLookUpR",         "eyesLookUpR"},
            {"InnerBrowRaiserL",    "innerBrowRaiserL"},
            {"InnerBrowRaiserR",    "innerBrowRaiserR"},
            {"JawDrop",             "jawDrop"},
            {"JawSidewaysLeft",     "jawSidewaysLeft"},
            {"JawSidewaysRight",    "jawSidewaysRight"},
            {"JawThrust",           "jawThrust"},
            {"LidTightenerL",       "lidTightenerL"},
            {"LidTightenerR",       "lidTightenerR"},
            {"LipCornerDepressorL", "lipCornerDepressorL"},
            {"LipCornerDepressorR", "lipCornerDepressorR"},
            {"LipCornerPullerL",    "lipCornerPullerL"},
            {"LipCornerPullerR",    "lipCornerPullerR"},
            {"LipFunnelerLB",       "lipFunnelerLB"},
            {"LipFunnelerLT",       "lipFunnelerLT"},
            {"LipFunnelerRB",       "lipFunnelerRB"},
            {"LipFunnelerRT",       "lipFunnelerRT"},
            {"LipPressorL",         "lipPressorL"},
            {"LipPressorR",         "lipPressorR"},
            {"LipPuckerL",          "lipPuckerL"},
            {"LipPuckerR",          "lipPuckerR"},
            {"LipStretcherL",       "lipStretcherL"},
            {"LipStretcherR",       "lipStretcherR"},
            {"LipSuckLB",           "lipSuckLB"},
            {"LipSuckLT",           "lipSuckLT"},
            {"LipSuckRB",           "lipSuckRB"},
            {"LipSuckRT",           "lipSuckRT"},
            {"LipTightenerL",       "lipTightenerL"},
            {"LipTightenerR",       "lipTightenerR"},
            {"LipsToward",          "lipsToward"},
            {"LowerLipDepressorL",  "lowerLipDepressorL"},
            {"LowerLipDepressorR",  "lowerLipDepressorR"},
            {"MouthLeft",           "mouthLeft"},
            {"MouthRight",          "mouthRight"},
            {"NoseWrinklerL",       "noseWrinklerL"},
            {"NoseWrinklerR",       "noseWrinklerR"},
            {"OuterBrowRaiserL",    "outerBrowRaiserL"},
            {"OuterBrowRaiserR",    "outerBrowRaiserR"},
            {"UpperLidRaiserL",     "upperLidRaiserL"},
            {"UpperLidRaiserR",     "upperLidRaiserR"},
            {"UpperLipRaiserL",     "upperLipRaiserL"},
            {"UpperLipRaiserR",     "upperLipRaiserR"},
        };

        public static readonly Dictionary<string, string> clipNameTable_quest_VRoid = new Dictionary<string, string>()
        {
            {"BrowLowererL",        "browLowererL"},
            {"BrowLowererR",        "browLowererR"},
            {"CheekPuffL",          "cheekPuffL"},
            {"CheekPuffR",          "cheekPuffR"},
            {"CheekRaiserL",        "cheekRaiserL"},
            {"CheekRaiserR",        "cheekRaiserR"},
            {"CheekSuckL",          "cheekSuckL"},
            {"CheekSuckR",          "cheekSuckR"},
            {"ChinRaiserB",         "chinRaiserB"},
            {"ChinRaiserT",         "chinRaiserT"},
            {"DimplerL",            "dimplerL"},
            {"DimplerR",            "dimplerR"},
            {"EyesClosedL",         "Fcl_EYE_Close_L"},
            {"EyesClosedR",         "Fcl_EYE_Close_R"},
            {"EyesLookDownL",       "eyesLookDownL"},
            {"EyesLookDownR",       "eyesLookDownR"},
            {"EyesLookLeftL",       "eyesLookLeftL"},
            {"EyesLookLeftR",       "eyesLookLeftR" },
            {"EyesLookRightL",      "eyesLookRightL"},
            {"EyesLookRightR",      "eyesLookRightR"},
            {"EyesLookUpL",         "eyesLookUpL"},
            {"EyesLookUpR",         "eyesLookUpR"},
            {"InnerBrowRaiserL",    "innerBrowRaiserL"},
            {"InnerBrowRaiserR",    "innerBrowRaiserR"},
            {"JawDrop",             "jawDrop"},
            {"JawSidewaysLeft",     "jawSidewaysLeft"},
            {"JawSidewaysRight",    "jawSidewaysRight"},
            {"JawThrust",           "jawThrust"},
            {"LidTightenerL",       "lidTightenerL"},
            {"LidTightenerR",       "lidTightenerR"},
            {"LipCornerDepressorL", "lipCornerDepressorL"},
            {"LipCornerDepressorR", "lipCornerDepressorR"},
            {"LipCornerPullerL",    "lipCornerPullerL"},
            {"LipCornerPullerR",    "lipCornerPullerR"},
            {"LipFunnelerLB",       "lipFunnelerLB"},
            {"LipFunnelerLT",       "lipFunnelerLT"},
            {"LipFunnelerRB",       "lipFunnelerRB"},
            {"LipFunnelerRT",       "lipFunnelerRT"},
            {"LipPressorL",         "lipPressorL"},
            {"LipPressorR",         "lipPressorR"},
            {"LipPuckerL",          "lipPuckerL"},
            {"LipPuckerR",          "lipPuckerR"},
            {"LipStretcherL",       "lipStretcherL"},
            {"LipStretcherR",       "lipStretcherR"},
            {"LipSuckLB",           "lipSuckLB"},
            {"LipSuckLT",           "lipSuckLT"},
            {"LipSuckRB",           "lipSuckRB"},
            {"LipSuckRT",           "lipSuckRT"},
            {"LipTightenerL",       "lipTightenerL"},
            {"LipTightenerR",       "lipTightenerR"},
            {"LipsToward",          "lipsToward"},
            {"LowerLipDepressorL",  "lowerLipDepressorL"},
            {"LowerLipDepressorR",  "lowerLipDepressorR"},
            {"MouthLeft",           "mouthLeft"},
            {"MouthRight",          "mouthRight"},
            {"NoseWrinklerL",       "noseWrinklerL"},
            {"NoseWrinklerR",       "noseWrinklerR"},
            {"OuterBrowRaiserL",    "outerBrowRaiserL"},
            {"OuterBrowRaiserR",    "outerBrowRaiserR"},
            {"UpperLidRaiserL",     "upperLidRaiserL"},
            {"UpperLidRaiserR",     "upperLidRaiserR"},
            {"UpperLipRaiserL",     "upperLipRaiserL"},
            {"UpperLipRaiserR",     "upperLipRaiserR"},
        };

        public static readonly Dictionary<string, string> clipNameTable_quest_arkit = new Dictionary<string, string>()
        {
            {"BrowLowererL",        "browDownLeft"},
            {"BrowLowererR",        "browDownRight"},
            {"CheekPuffL",          "cheekPuff"},
            {"CheekPuffR",          "cheekPuff"},
            {"CheekRaiserL",        "cheekSquintLeft"},
            {"CheekRaiserR",        "cheekSquintRight"},
            {"CheekSuckL",          "dummy"},
            {"CheekSuckR",          "dummy"},
            {"ChinRaiserT",         "mouthShrugUpper"},
            {"ChinRaiserB",         "mouthShrugLower"},
            {"DimplerL",            "mouthDimpleLeft"},
            {"DimplerR",            "mouthDimpleRight"},
            {"EyesClosedL",         "eyeBlinkLeft"},
            {"EyesClosedR",         "eyeBlinkRight"},
            {"EyesLookDownL",       "eyeLookDownLeft"},
            {"EyesLookDownR",       "eyeLookDownRight"},
            {"EyesLookLeftL",       "eyeLookOutLeft"},
            {"EyesLookLeftR",       "eyeLookInRight" },
            {"EyesLookRightL",      "eyeLookInLeft"},
            {"EyesLookRightR",      "eyeLookOutRight"},
            {"EyesLookUpL",         "eyeLookUpLeft"},
            {"EyesLookUpR",         "eyeLookUpRight"},
            {"InnerBrowRaiserL",    "browInnerUp"},
            {"InnerBrowRaiserR",    "browInnerUp"},
            {"JawDrop",             "jawOpen"},
            {"JawSidewaysLeft",     "jawLeft"},
            {"JawSidewaysRight",    "jawRight"},
            {"JawThrust",           "jawForward"},
            {"LidTightenerL",       "eyeSquintLeft"},
            {"LidTightenerR",       "eyeSquintRight"},
            {"LipCornerDepressorL", "mouthFrownLeft"},
            {"LipCornerDepressorR", "mouthFrownRight"},
            {"LipCornerPullerL",    "mouthSmileLeft"},
            {"LipCornerPullerR",    "mouthSmileRight"},
            {"LipFunnelerLB",       "mouthFunnel"},
            {"LipFunnelerLT",       "mouthFunnel"},
            {"LipFunnelerRB",       "mouthFunnel"},
            {"LipFunnelerRT",       "mouthFunnel"},
            {"LipPressorL",         "dummy"},
            {"LipPressorR",         "dummy"},
            {"LipPuckerL",          "mouthPucker"},
            {"LipPuckerR",          "mouthPucker"},
            {"LipStretcherL",       "mouthStretchLeft"},
            {"LipStretcherR",       "mouthStretchRight"},
            {"LipSuckLB",           "mouthRollLower"},
            {"LipSuckLT",           "mouthRollUpper"},
            {"LipSuckRB",           "mouthRollLower"},
            {"LipSuckRT",           "mouthRollUpper"},
            {"LipTightenerL",       "mouthPressLeft"},
            {"LipTightenerR",       "mouthPressRight"},
            {"LipsToward",          "mouthClose"},
            {"LowerLipDepressorL",  "mouthLowerDownLeft"},
            {"LowerLipDepressorR",  "mouthLowerDownRight"},
            {"MouthLeft",           "mouthLeft"},
            {"MouthRight",          "mouthRight"},
            {"NoseWrinklerL",       "noseSneerLeft"},
            {"NoseWrinklerR",       "noseSneerRight"},
            {"OuterBrowRaiserL",    "browOuterUpLeft"},
            {"OuterBrowRaiserR",    "browOuterUpRight"},
            {"UpperLidRaiserL",     "eyeWideLeft"},
            {"UpperLidRaiserR",     "eyeWideRight"},
            {"UpperLipRaiserL",     "mouthUpperUpLeft"},
            {"UpperLipRaiserR",     "mouthUpperUpRight"},
        };

        public static readonly Dictionary<string, float> clipWeightTable_quest = new Dictionary<string, float>()
        {
            {"BrowLowererL",        100.0f},
            {"BrowLowererR",        100.0f},
            {"CheekPuffL",          50.0f},
            {"CheekPuffR",          50.0f},
            {"CheekRaiserL",        100.0f},
            {"CheekRaiserR",        100.0f},
            {"CheekSuckL",          100.0f},
            {"CheekSuckR",          100.0f},
            {"ChinRaiserB",         100.0f},
            {"ChinRaiserT",         100.0f},
            {"DimplerL",            100.0f},
            {"DimplerR",            100.0f},
            {"EyesClosedL",         100.0f},
            {"EyesClosedR",         100.0f},
            {"EyesLookDownL",       100.0f},
            {"EyesLookDownR",       100.0f},
            {"EyesLookLeftL",       100.0f},
            {"EyesLookLeftR",       100.0f},
            {"EyesLookRightL",      100.0f},
            {"EyesLookRightR",      100.0f},
            {"EyesLookUpL",         100.0f},
            {"EyesLookUpR",         100.0f},
            {"InnerBrowRaiserL",    50.0f},
            {"InnerBrowRaiserR",    50.0f},
            {"JawDrop",             100.0f},
            {"JawSidewaysLeft",     100.0f},
            {"JawSidewaysRight",    100.0f},
            {"JawThrust",           100.0f},
            {"LidTightenerL",       100.0f},
            {"LidTightenerR",       100.0f},
            {"LipCornerDepressorL", 100.0f},
            {"LipCornerDepressorR", 100.0f},
            {"LipCornerPullerL",    100.0f},
            {"LipCornerPullerR",    100.0f},
            {"LipFunnelerLB",       25.0f},
            {"LipFunnelerLT",       25.0f},
            {"LipFunnelerRB",       25.0f},
            {"LipFunnelerRT",       25.0f},
            {"LipPressorL",         100.0f},
            {"LipPressorR",         100.0f},
            {"LipPuckerL",          50.0f},
            {"LipPuckerR",          50.0f},
            {"LipStretcherL",       100.0f},
            {"LipStretcherR",       100.0f},
            {"LipSuckLB",           50.0f},
            {"LipSuckLT",           50.0f},
            {"LipSuckRB",           50.0f},
            {"LipSuckRT",           50.0f},
            {"LipTightenerL",       100.0f},
            {"LipTightenerR",       100.0f},
            {"LipsToward",          100.0f},
            {"LowerLipDepressorL",  100.0f},
            {"LowerLipDepressorR",  100.0f},
            {"MouthLeft",           100.0f},
            {"MouthRight",          100.0f},
            {"NoseWrinklerL",       100.0f},
            {"NoseWrinklerR",       100.0f},
            {"OuterBrowRaiserL",    100.0f},
            {"OuterBrowRaiserR",    100.0f},
            {"UpperLidRaiserL",     100.0f},
            {"UpperLidRaiserR",     100.0f},
            {"UpperLipRaiserL",     100.0f},
            {"UpperLipRaiserR",     100.0f},
        };
    }
}
