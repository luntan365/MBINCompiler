﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0C9FFFC7A5A173EEC)]
    public class GcMissionConditionFrigateCount : NMSTemplate
    {
        public int FrigateCount;
        public TkEqualityEnum Test;
    }
}