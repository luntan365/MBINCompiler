﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x864F2894AB6F76AE)]
    public class GcProductTable : NMSTemplate
    {
        public List<GcProductData> Table;
    }
}
