﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x901EC91DF16D7A41)]
    public class GcAlienMood : NMSTemplate
    {
        public enum MoodEnum { Neutral, Positive, VeryPositive, Negative, VeryNegative, Pity, Sad, Dead, Confused }
        public MoodEnum Mood;
    }
}