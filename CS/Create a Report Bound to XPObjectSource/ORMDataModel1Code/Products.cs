﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Create_a_Report_Bound_to_XPObjectSource.nwind {

    public partial class Products {
        public Products(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
