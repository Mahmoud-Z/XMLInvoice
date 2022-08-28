using E_Invoice.Core.XMLStructure;
using System.Collections.Generic;

namespace XmlTest
{
    public static class ExtensionSource
    {
        public static Invoice MapInvoiceRoot(this Invoice source)
        {
            source.ID = new ID { Value = "100" };
            //retrieve from DB or no>!
            source.UUID = "3cf5ee18-ee25-44ea-a444-2c37ba7f28be";
            source.IssueDate = "2021-04-25";
            source.IssueTime = "15:30:00";

            source.InvoiceTypeCode = new InvoiceTypeCode
            {
                name = "0100000",
                Value = 388
            };
            //source.Note = document.DocumentPayment.Notes;
            source.DocumentCurrencyCode = "SAR";
            source.TaxCurrencyCode = "SAR";
            //source.LineCountNumeric = ;
            source.OrderReference = new OrderReference
            {
                ID = new ID { Value = null }
            };

            //if (documentType == DocumentTypeEnum.Credit_Notes_Tax_Invoice || documentType == DocumentTypeEnum.Debit_Notes_Tax_Invoice ||
            //   documentType == DocumentTypeEnum.Credit_Notes_Simplified_Tax || documentType == DocumentTypeEnum.Debit_Notes_Simplified_Tax)
            //{
                source.BillingReference = new BillingReference
                {
                    InvoiceDocumentReference = new BillingReferenceInvoiceDocumentReference
                    {
                        ID = new ID { Value = null }
                    }
                };
            //}
            source.ContractDocumentReference = new ContractDocumentReference
            {
                ID = new ID { Value = null }
            };
            return source;
        }
        public static Invoice MapDocumentReference(this Invoice source)
        {
            source.AdditionalDocumentReference = new List<AdditionalDocumentReference>
            {
                new AdditionalDocumentReference
                {
                    ID= new ID { Value = "ICV" },
                    UUID= "46531",
                },
                new AdditionalDocumentReference
                {
                    ID= new ID { Value = "PIH" },
                    Attachment=new AdditionalDocumentReferenceAttachment
                    {
                        EmbeddedDocumentBinaryObject=new EmbeddedDocumentBinaryObject
                        {
                            Value="NWZlY2ViNjZmZmM4NmYzOGQ5NTI3ODZjNmQ2OTZjNzljMmRiYzIzOWRkNGU5MWI0NjcyOWQ3M2EyN2ZiNTdlOQ==",
                            mimeCode = "text/plain"
                        }
                    },
                },
                new AdditionalDocumentReference
                {
                    ID= new ID { Value = "QR" },
                    Attachment=new AdditionalDocumentReferenceAttachment
                    {
                        EmbeddedDocumentBinaryObject=new EmbeddedDocumentBinaryObject
                        {
                            Value="ARlBbCBTYWxhbSBTdXBwbGllcyBDby4gTFREAg8zMDAwNTUxODQ0MDAwMDMDFDIwMjEtMDQtMjVUMTU6MzA6MDBaBAcxMDM1LjAwBQYxMzUuMDAGLG1mVkNpcHlaUG1IZzFpU3QreWJSYlJMaFAreGZuSDVmZnNMYXdkaXU2UEk9B1gwVjAQBgcqhkjOPQIBBgUrgQQACgNCAATTAK9lrTVko9rkq6ZYcc9HDRZP4b9S4zA4Km7YXJ+snTVhLkzU0HsmSX9Un8jDhRTOHDKaft8C/uuUY934vuMNCCEAnHTyqYXeVhBdCUO9gq4nX73oEgVZCjZ8STz9QY7Sy1sJIBkN9Q56qQGMZly02uwNYqXPAagxEF1tqxImEczcDbK2",
                            mimeCode = "text/plain"
                        }
                    },
                },
            };
            return source;
        }
        public static AccountingSupplierParty MapAccountingSupplierParty(this AccountingSupplierParty source)
        {
            source.Party = new AccountingSupplierPartyParty
            {
                PartyIdentification = new AccountingSupplierPartyPartyPartyIdentification
                {
                    ID = new ID { Value = "123457890", schemeID = "MLS" },//Question
                },
                PartyLegalEntity = new AccountingSupplierPartyPartyPartyLegalEntity
                {
                    RegistrationName = "Al Salam Supplies Co. LTD",
                },
                PartyTaxScheme = new AccountingSupplierPartyPartyPartyTaxScheme
                {
                    CompanyID = "300055184400003",//Question
                    TaxScheme = new AccountingSupplierPartyPartyPartyTaxSchemeTaxScheme
                    {
                        ID = new ID { Value = "VAT" },//Question
                    },
                },
                PostalAddress = new AccountingSupplierPartyPartyPostalAddress
                {
                    AdditionalStreetName = null,
                    BuildingNumber = "8228",
                    CityName = "Riyadh",
                    CitySubdivisionName = "Al Amal",
                    Country = new AccountingSupplierPartyPartyPostalAddressCountry
                    {
                        IdentificationCode = "SA"
                    },
                    CountrySubentity = "Riyadh Region",
                    PlotIdentification = "2121",
                    PostalZone = "12643",
                    StreetName = "King Abdulaziz Road"
                }
            };
            return source;
        }
        public static AccountingCustomerParty MapAccountingCustomerParty(this AccountingCustomerParty source)
        {
            source.Party = new AccountingCustomerPartyParty
            {
                PartyIdentification = new AccountingCustomerPartyPartyPartyIdentification
                {
                    ID = new ID { Value = "123C12345678",schemeID= "SAG" },
                },
                PartyLegalEntity = new AccountingCustomerPartyPartyPartyLegalEntity
                {
                    RegistrationName = "AL KAWTHAR MARKETS",
                },
                PartyTaxScheme = new AccountingCustomerPartyPartyPartyTaxScheme
                {
                    CompanyID = null,
                    TaxScheme = new AccountingCustomerPartyPartyPartyTaxSchemeTaxScheme
                    {
                        ID = new ID { Value = "VAT" },
                    },
                },
                PostalAddress = new AccountingCustomerPartyPartyPostalAddress
                {
                    AdditionalStreetName = null,
                    BuildingNumber = "3709",
                    CityName = "Riyadh",
                    CitySubdivisionName = "Al Mursalat",
                    Country = new AccountingCustomerPartyPartyPostalAddressCountry
                    {
                        IdentificationCode = "SA"
                    },
                    CountrySubentity = "Riyadh Region",
                    PlotIdentification = "1004",
                    PostalZone = "11564",
                    StreetName = "King Abdullah Road"

                },
            };
            return source;
        }
        public static Invoice MapCharge(this Invoice source)
        {
            source.Delivery = new Delivery
            {
                ActualDeliveryDate = "2022-04-25",
                LatestDeliveryDate = null,
            };
            source.PaymentMeans = new PaymentMeans
            {
                InstructionNote = null,
                PayeeFinancialAccount = new PaymentMeansPayeeFinancialAccount
                {
                    ID = new ID { Value = null },//Question (it's row is empty in the data dictionary)
                    PaymentNote = null,
                },
                PaymentMeansCode = new PaymentMeansCode
                {
                    listID = null,//Question (Missing from data dictionary)
                    Value = "42"
                }
            };
            source.AllowanceCharge = new AllowanceCharge
            {
                Amount = new Amount
                {
                    currencyID = null,
                    Value = 0
                },
                BaseAmount = new BaseAmount()
                {
                    currencyID = null,
                    Value = 0
                },
                ChargeIndicator = false,
                MultiplierFactorNumeric = 0,
                TaxCategory = new AllowanceChargeTaxCategory
                {
                    ID = new ID { Value = null },
                    Percent = 0,
                    TaxScheme = new AllowanceChargeTaxCategoryTaxScheme
                    {
                        ID = new ID { Value = null }//Question (In data dictionary it says "Item_Tax_schema_ID" but this is only in documentLine class and it's a list?)
                    }
                }
            };
            return source;
        }
        public static Invoice MapTotal(this Invoice source)
        {
            source.TaxTotal = new List<TaxTotal>
            {
                new TaxTotal
                {
                    TaxAmount = new TaxAmount[]
                    {
                        new TaxAmount
                        {
                            currencyID = "SAR",
                            Value = 30.00M
                        },
                    },
                    TaxSubtotal=new List<TaxTotalTaxSubtotal>
                    {
                        new TaxTotalTaxSubtotal
                        {
                            TaxableAmount=new TaxableAmount
                            {
                                currencyID="SAR",
                                Value=200.00M
                            },
                            TaxAmount  = new TaxAmount
                            {
                                currencyID="SAR",
                                Value=30.00M
                            },
                            TaxCategory=new TaxTotalTaxSubtotalTaxCategory
                            {
                                ID=new ID{Value="S"},
                                Percent=15,
                                TaxScheme = new TaxTotalTaxSubtotalTaxCategoryTaxScheme
                                {
                                    ID=new ID{Value="VAT"}
                                }
                            }
                        }
                    }
                },
                new TaxTotal
                {
                    TaxAmount = new TaxAmount[]
                    {
                        new TaxAmount
                        {
                            currencyID = "SAR",
                            Value = 135.00M
                        },
                        //new TaxAmount
                        //{
                        //    currencyID = document.DocumentSummary.Total_VAT_Accounting_Curreny_Code,
                        //    Value = document.DocumentSummary.Total_VAT_Accounting_Amount ?? 0
                        //}
                    },
                }
                
                //TaxSubtotal = new List<TaxTotalTaxSubtotal>()
            };
            source.LegalMonetaryTotal = new LegalMonetaryTotal
            {
                AllowanceTotalAmount = new AllowanceTotalAmount
                {
                    currencyID = "SAR",
                    Value = 0.00M
                },
                LineExtensionAmount = new LineExtensionAmount
                {
                    currencyID = "SAR",
                    Value = 200.00M
                },
                PayableAmount = new PayableAmount
                {
                    currencyID = "SAR",
                    Value = 230.00M
                },
                PrepaidAmount = new PrepaidAmount
                {
                    currencyID = null,
                    Value = 0
                },
                TaxExclusiveAmount = new TaxExclusiveAmount
                {
                    currencyID = "SAR",
                    Value = 200.00M
                },
                TaxInclusiveAmount = new TaxInclusiveAmount
                {
                    currencyID = "SAR",
                    Value = 230.00M
                },
            };
            //foreach (var breakDown in vatBreakDowns)
            //{
            //    var item = new TaxTotalTaxSubtotal()
            //    {
            //        TaxAmount = new TaxAmount
            //        {
            //            currencyID = breakDown.Category_Tax_Currency_Code,
            //            Value = breakDown.Category_Tax_Amount ?? 0
            //        },
            //        TaxableAmount = new TaxableAmount
            //        {
            //            currencyID = breakDown.Category_Taxable_Currency_Code,
            //            Value = breakDown.Category_Taxable_Amount ?? 0
            //        },
            //        TaxCategory = new TaxTotalTaxSubtotalTaxCategory
            //        {
            //            ID = new ID { Value = breakDown.Category_Code },
            //            Percent = breakDown.Category_Rate ?? 0,
            //            TaxExemptionReason = breakDown.Exemption_Reason_Text,
            //            TaxExemptionReasonCode = breakDown.Exemption_Reason_Code,
            //            TaxScheme = new TaxTotalTaxSubtotalTaxCategoryTaxScheme
            //            {
            //                ID = new ID { Value = breakDown.VAT_Tax_Scheme_ID /*document.DocumentAllowance.Allowance_Tax_Scheme_ID*/ }
            //            }
            //        },
            //    };
            //    source.TaxTotal.TaxSubtotal.Add(item);
            //}
            return source;
        }
        public static Invoice MapDocumentLines(this Invoice source)
        {
            source.InvoiceLine = new List<InvoiceLine>
            {
                new InvoiceLine
                {ID = new ID { Value = "1" },
            AllowanceCharge = new InvoiceLineAllowanceCharge
            {
                Amount = new Amount
                {
                    currencyID = null,
                    Value = 0//Question (can't find in datadictionary)
                },
                BaseAmount = new BaseAmount
                {
                    currencyID = null,
                    Value = 0//Question (can't find in datadictionary)
                },
                ChargeIndicator = false,
                MultiplierFactorNumeric = 0//Question (Can't find in data dictionary)
            },
            InvoicedQuantity = new InvoicedQuantity
            {
                unitCode = "PCE",
                Value = 1
            },
            Item = new InvoiceLineItem
            {
                BuyersItemIdentification = new InvoiceLineItemBuyersItemIdentification
                {
                    ID = new ID { Value = null }
                },
                ClassifiedTaxCategory = new InvoiceLineItemClassifiedTaxCategory
                {
                    ID = new ID { Value = "S"/*, schemeID, schemeAgencyIDSpecified, schemeAgencyID */},//Question(can't find all 2 attributes in the data dictionary)
                    Percent = 15,
                    TaxScheme = new InvoiceLineItemClassifiedTaxCategoryTaxScheme
                    {
                        ID = new ID { Value = "VAT"/*, schemeID, schemeAgencyIDSpecified, schemeAgencyID */}
                    }
                },
                Name = "Item A",
                SellersItemIdentification = new InvoiceLineItemSellersItemIdentification
                {
                    ID = new ID { Value = null }
                },
                StandardItemIdentification = new InvoiceLineItemStandardItemIdentification
                {
                    ID = new ID { Value = null/*,schemeID,schemeAgencyIDSpecified,schemeAgencyID */}//Question (can'tfind all three attributes in the data dictionary)
                },
            },
            LineExtensionAmount = new LineExtensionAmount
            {
                currencyID = "SAR",
                Value = 200.00M
            },
            Price = new InvoiceLinePrice
            {
                AllowanceCharge = new InvoiceLinePriceAllowanceCharge
                {
                    Amount = new Amount
                    {
                    currencyID = null,
                    Value = 0//Question (can't find in datadictionary)
                    },
                    BaseAmount = new BaseAmount
                    {
                    currencyID = null,
                    Value = 0//Question (can't find in datadictionary)
                    },
                    ChargeIndicator = false
                },
                BaseQuantity = new BaseQuantity
                {
                    unitCode = null,
                    Value = 0
                },
                PriceAmount = new PriceAmount
                {
                    currencyID = "SAR",
                    Value = 200.00M
                },
            },
            TaxTotal = new InvoiceLineTaxTotal
            {
                RoundingAmount = new RoundingAmount
                {
                    currencyID = "SAR",
                    Value = 230.00M
                },
                TaxAmount = new TaxAmount
                {
                    currencyID = "SAR",
                    Value = 30.00M
                }
            }
            }
            };
            return source;
        }
    }
}
