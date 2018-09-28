﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Create_a_Report_Bound_to_XPObjectSource.nwind {

    public partial class Products : XPLiteObject {
        Categories fCategoryID;
        [Association(@"ProductsReferencesCategories")]
        public Categories CategoryID {
            get { return fCategoryID; }
            set { SetPropertyValue<Categories>(nameof(CategoryID), ref fCategoryID, value); }
        }
        bool fDiscontinued;
        [ColumnDbDefaultValue("=No")]
        public bool Discontinued {
            get { return fDiscontinued; }
            set { SetPropertyValue<bool>(nameof(Discontinued), ref fDiscontinued, value); }
        }
        string fEAN13;
        [Size(12)]
        [ColumnDbDefaultValue("0")]
        public string EAN13 {
            get { return fEAN13; }
            set { SetPropertyValue<string>(nameof(EAN13), ref fEAN13, value); }
        }
        int fProductID;
        [Key(true)]
        public int ProductID {
            get { return fProductID; }
            set { SetPropertyValue<int>(nameof(ProductID), ref fProductID, value); }
        }
        string fProductName;
        [Indexed(Name = @"ProductName")]
        [Size(40)]
        public string ProductName {
            get { return fProductName; }
            set { SetPropertyValue<string>(nameof(ProductName), ref fProductName, value); }
        }
        string fQuantityPerUnit;
        [Size(20)]
        public string QuantityPerUnit {
            get { return fQuantityPerUnit; }
            set { SetPropertyValue<string>(nameof(QuantityPerUnit), ref fQuantityPerUnit, value); }
        }
        short fReorderLevel;
        [ColumnDbDefaultValue("0")]
        public short ReorderLevel {
            get { return fReorderLevel; }
            set { SetPropertyValue<short>(nameof(ReorderLevel), ref fReorderLevel, value); }
        }
        int fSupplierID;
        [Indexed(Name = @"SupplierID")]
        public int SupplierID {
            get { return fSupplierID; }
            set { SetPropertyValue<int>(nameof(SupplierID), ref fSupplierID, value); }
        }
        decimal fUnitPrice;
        [ColumnDbDefaultValue("0")]
        public decimal UnitPrice {
            get { return fUnitPrice; }
            set { SetPropertyValue<decimal>(nameof(UnitPrice), ref fUnitPrice, value); }
        }
        short fUnitsInStock;
        [ColumnDbDefaultValue("0")]
        public short UnitsInStock {
            get { return fUnitsInStock; }
            set { SetPropertyValue<short>(nameof(UnitsInStock), ref fUnitsInStock, value); }
        }
        short fUnitsOnOrder;
        [ColumnDbDefaultValue("0")]
        public short UnitsOnOrder {
            get { return fUnitsOnOrder; }
            set { SetPropertyValue<short>(nameof(UnitsOnOrder), ref fUnitsOnOrder, value); }
        }
    }

}
