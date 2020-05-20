using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWStestes
{
    class wsMovRM
    {

        // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/XSL/Transform")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/1999/XSL/Transform", IsNullable = false)]
        public partial class stylesheet
        {

            private stylesheetTemplate templateField;

            private decimal versionField;

            /// <remarks/>
            public stylesheetTemplate template
            {
                get
                {
                    return this.templateField;
                }
                set
                {
                    this.templateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/XSL/Transform")]
        public partial class stylesheetTemplate
        {

            private TOTVSMessage tOTVSMessageField;

            private string matchField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public TOTVSMessage TOTVSMessage
            {
                get
                {
                    return this.tOTVSMessageField;
                }
                set
                {
                    this.tOTVSMessageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string match
            {
                get
                {
                    return this.matchField;
                }
                set
                {
                    this.matchField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class TOTVSMessage
        {

            private TOTVSMessageMessageInformation messageInformationField;

            private TOTVSMessageBusinessMessage businessMessageField;

            /// <remarks/>
            public TOTVSMessageMessageInformation MessageInformation
            {
                get
                {
                    return this.messageInformationField;
                }
                set
                {
                    this.messageInformationField = value;
                }
            }

            /// <remarks/>
            public TOTVSMessageBusinessMessage BusinessMessage
            {
                get
                {
                    return this.businessMessageField;
                }
                set
                {
                    this.businessMessageField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TOTVSMessageMessageInformation
        {

            private string uUIDField;

            private string typeField;

            private string transactionField;

            private ushort standardVersionField;

            private string sourceApplicationField;

            private byte companyIdField;

            private string productField;

            private System.DateTime generatedOnField;

            private string deliveryTypeField;

            private byte qUEUETYPEField;

            /// <remarks/>
            public string UUID
            {
                get
                {
                    return this.uUIDField;
                }
                set
                {
                    this.uUIDField = value;
                }
            }

            /// <remarks/>
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            public string Transaction
            {
                get
                {
                    return this.transactionField;
                }
                set
                {
                    this.transactionField = value;
                }
            }

            /// <remarks/>
            public ushort StandardVersion
            {
                get
                {
                    return this.standardVersionField;
                }
                set
                {
                    this.standardVersionField = value;
                }
            }

            /// <remarks/>
            public string SourceApplication
            {
                get
                {
                    return this.sourceApplicationField;
                }
                set
                {
                    this.sourceApplicationField = value;
                }
            }

            /// <remarks/>
            public byte CompanyId
            {
                get
                {
                    return this.companyIdField;
                }
                set
                {
                    this.companyIdField = value;
                }
            }

            /// <remarks/>
            public string Product
            {
                get
                {
                    return this.productField;
                }
                set
                {
                    this.productField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime GeneratedOn
            {
                get
                {
                    return this.generatedOnField;
                }
                set
                {
                    this.generatedOnField = value;
                }
            }

            /// <remarks/>
            public string DeliveryType
            {
                get
                {
                    return this.deliveryTypeField;
                }
                set
                {
                    this.deliveryTypeField = value;
                }
            }

            /// <remarks/>
            public byte QUEUETYPE
            {
                get
                {
                    return this.qUEUETYPEField;
                }
                set
                {
                    this.qUEUETYPEField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TOTVSMessageBusinessMessage
        {

            private TOTVSMessageBusinessMessageBusinessEvent businessEventField;

            private TOTVSMessageBusinessMessageBusinessContent businessContentField;

            /// <remarks/>
            public TOTVSMessageBusinessMessageBusinessEvent BusinessEvent
            {
                get
                {
                    return this.businessEventField;
                }
                set
                {
                    this.businessEventField = value;
                }
            }

            /// <remarks/>
            public TOTVSMessageBusinessMessageBusinessContent BusinessContent
            {
                get
                {
                    return this.businessContentField;
                }
                set
                {
                    this.businessContentField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TOTVSMessageBusinessMessageBusinessEvent
        {

            private string entityField;

            private string eventField;

            private TOTVSMessageBusinessMessageBusinessEventKey[] identificationField;

            /// <remarks/>
            public string Entity
            {
                get
                {
                    return this.entityField;
                }
                set
                {
                    this.entityField = value;
                }
            }

            /// <remarks/>
            public string Event
            {
                get
                {
                    return this.eventField;
                }
                set
                {
                    this.eventField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("key", IsNullable = false)]
            public TOTVSMessageBusinessMessageBusinessEventKey[] Identification
            {
                get
                {
                    return this.identificationField;
                }
                set
                {
                    this.identificationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TOTVSMessageBusinessMessageBusinessEventKey
        {

            private string nameField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TOTVSMessageBusinessMessageBusinessContent
        {

            private string companyIdField;

            private string codeField;

            private string codeTypeMovField;

            private string branchCodeField;

            private string codeLocField;

            private string typeField;

            private string statusField;

            private string costCenterCodeField;

            private string lanDateField;

            private string issueDateField;

            private string cancelDateField;

            private string paymentCoditionField;

            private string valueDiscountField;

            private string valueExpenditureField;

            private string valueGrossField;

            private string valueField;

            private TOTVSMessageBusinessMessageBusinessContentListItems listItemsField;

            /// <remarks/>
            public string CompanyId
            {
                get
                {
                    return this.companyIdField;
                }
                set
                {
                    this.companyIdField = value;
                }
            }

            /// <remarks/>
            public string Code
            {
                get
                {
                    return this.codeField;
                }
                set
                {
                    this.codeField = value;
                }
            }

            /// <remarks/>
            public string CodeTypeMov
            {
                get
                {
                    return this.codeTypeMovField;
                }
                set
                {
                    this.codeTypeMovField = value;
                }
            }

            /// <remarks/>
            public string BranchCode
            {
                get
                {
                    return this.branchCodeField;
                }
                set
                {
                    this.branchCodeField = value;
                }
            }

            /// <remarks/>
            public string CodeLoc
            {
                get
                {
                    return this.codeLocField;
                }
                set
                {
                    this.codeLocField = value;
                }
            }

            /// <remarks/>
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public string CostCenterCode
            {
                get
                {
                    return this.costCenterCodeField;
                }
                set
                {
                    this.costCenterCodeField = value;
                }
            }

            /// <remarks/>
            public string LanDate
            {
                get
                {
                    return this.lanDateField;
                }
                set
                {
                    this.lanDateField = value;
                }
            }

            /// <remarks/>
            public string IssueDate
            {
                get
                {
                    return this.issueDateField;
                }
                set
                {
                    this.issueDateField = value;
                }
            }

            /// <remarks/>
            public string CancelDate
            {
                get
                {
                    return this.cancelDateField;
                }
                set
                {
                    this.cancelDateField = value;
                }
            }

            /// <remarks/>
            public string PaymentCodition
            {
                get
                {
                    return this.paymentCoditionField;
                }
                set
                {
                    this.paymentCoditionField = value;
                }
            }

            /// <remarks/>
            public string ValueDiscount
            {
                get
                {
                    return this.valueDiscountField;
                }
                set
                {
                    this.valueDiscountField = value;
                }
            }

            /// <remarks/>
            public string ValueExpenditure
            {
                get
                {
                    return this.valueExpenditureField;
                }
                set
                {
                    this.valueExpenditureField = value;
                }
            }

            /// <remarks/>
            public string ValueGross
            {
                get
                {
                    return this.valueGrossField;
                }
                set
                {
                    this.valueGrossField = value;
                }
            }

            /// <remarks/>
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            public TOTVSMessageBusinessMessageBusinessContentListItems ListItems
            {
                get
                {
                    return this.listItemsField;
                }
                set
                {
                    this.listItemsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TOTVSMessageBusinessMessageBusinessContentListItems
        {

            private TOTVSMessageBusinessMessageBusinessContentListItemsItems itemsField;

            /// <remarks/>
            public TOTVSMessageBusinessMessageBusinessContentListItemsItems Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TOTVSMessageBusinessMessageBusinessContentListItemsItems
        {

            private string companyIdField;

            private string codeField;

            private string codePrdField;

            private string amountField;

            private string codeUndField;

            private string valueUnitField;

            private string valueDiscountField;

            private string valueExpenditureField;

            private string valueTotalField;

            private string valueField;

            /// <remarks/>
            public string CompanyId
            {
                get
                {
                    return this.companyIdField;
                }
                set
                {
                    this.companyIdField = value;
                }
            }

            /// <remarks/>
            public string Code
            {
                get
                {
                    return this.codeField;
                }
                set
                {
                    this.codeField = value;
                }
            }

            /// <remarks/>
            public string CodePrd
            {
                get
                {
                    return this.codePrdField;
                }
                set
                {
                    this.codePrdField = value;
                }
            }

            /// <remarks/>
            public string Amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }

            /// <remarks/>
            public string CodeUnd
            {
                get
                {
                    return this.codeUndField;
                }
                set
                {
                    this.codeUndField = value;
                }
            }

            /// <remarks/>
            public string ValueUnit
            {
                get
                {
                    return this.valueUnitField;
                }
                set
                {
                    this.valueUnitField = value;
                }
            }

            /// <remarks/>
            public string ValueDiscount
            {
                get
                {
                    return this.valueDiscountField;
                }
                set
                {
                    this.valueDiscountField = value;
                }
            }

            /// <remarks/>
            public string ValueExpenditure
            {
                get
                {
                    return this.valueExpenditureField;
                }
                set
                {
                    this.valueExpenditureField = value;
                }
            }

            /// <remarks/>
            public string ValueTotal
            {
                get
                {
                    return this.valueTotalField;
                }
                set
                {
                    this.valueTotalField = value;
                }
            }

            /// <remarks/>
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }



    }
}
