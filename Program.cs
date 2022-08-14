using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace XmlTest
{
    //Omar Why?!
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------Fill xml with data-----------------------------------
            //StringBuilder sb = new StringBuilder(1024);
            //XDocument doc = XDocument.Load("E:\\Questions\\C# Projects\\XmlTest\\XMLFile1.xml");
            ////IEnumerable<XElement> orders = from order in doc.Elements("PLANT")
            ////                               where order.Element("ZONE").Value=="3"
            ////                               orderby order.Element("BOTANICAL").Value
            ////                               select order;
            //IEnumerable<XElement> orders = doc.XPathSelectElements("/CATALOG/PLANT[ZONE='3']");
            //foreach (XElement order in orders)
            //{
            //    sb.AppendLine(order.Element("BOTANICAL").Value);
            //}
            //Console.WriteLine(sb.ToString());            
            //----------------------------------Fill xml with data-----------------------------------
            string xmlFileName = @"C:\Users\MahmoudGamal\OneDrive - ACT\Desktop\Web\c#\PC\XmlTest\Test\";
            SerializeSampleViewModel<Invoice> serializeSample = new SerializeSampleViewModel<Invoice>();
            //CustomerRoot Entity = new CustomerRoot();
            //Entity.Customers = new List<Customer>(){
            //    new Customer()
            //{
            //    CompanyName = new CompanyName
            //    {
            //        Numberes =null ,
            //        type="Salary",
            //        value="ACT"
            //    },
            //    CustomerID = 1,
            //    FName = "Lamiaa",
            //}, new Customer()
            //{
            //    CompanyName =
            //    new CompanyName
            //    {
            //        type="Salary",
            //        value="ACT"
            //    },
            //    CustomerID = 2,
            //    FName = "Mahmoud",
            //    LName = "Gamal"
            //} };
            #region commentedInvoice
            //Invoice invoice = new Invoice();
            //invoice.ProfileID = "";
            //invoice.ID = new ID { Value = "test"};
            //invoice.UUID = "";
            //invoice.InvoiceTypeCode = new InvoiceTypeCode
            //{
            //    Value = 0
            //};
            //invoice.Note = "";
            //invoice.DocumentCurrencyCode = "";
            //invoice.TaxCurrencyCode = "";
            //invoice.OrderReference = new OrderReference
            //{
            //    ID = new ID { Value = "" }
            //};
            //invoice.BillingReference = new BillingReference
            //{
            //    InvoiceDocumentReference = new BillingReferenceInvoiceDocumentReference
            //    {
            //        ID = new ID { Value = "" }
            //    }
            //};
            //invoice.ContractDocumentReference = new ContractDocumentReference
            //{
            //    ID = new ID { Value = "" }
            //};
            //invoice.AdditionalDocumentReference = new AdditionalDocumentReference[]
            //{
            //    new AdditionalDocumentReference
            //    {
            //        ID= new ID { Value = "" },
            //        UUID="",
            //    },
            //    new AdditionalDocumentReference
            //    {
            //        ID= new ID { Value = "" },
            //        Attachment=new AdditionalDocumentReferenceAttachment
            //        {
            //            EmbeddedDocumentBinaryObject=new EmbeddedDocumentBinaryObject
            //            {
            //                Value=""
            //            }
            //        },
            //    },
            //    new AdditionalDocumentReference
            //    {
            //        ID= new ID { Value = "" },
            //        Attachment=new AdditionalDocumentReferenceAttachment
            //        {
            //            EmbeddedDocumentBinaryObject=new EmbeddedDocumentBinaryObject
            //            {
            //                Value=""
            //            }
            //        },
            //    },
            //};
            //invoice.UBLExtensions = new UBLExtensions
            //{
            //    UBLExtension = new UBLExtensionsUBLExtension
            //    {
            //        ExtensionContent = new UBLExtensionsUBLExtensionExtensionContent
            //        {
            //            UBLDocumentSignatures = new UBLDocumentSignatures
            //            {
            //                SignatureInformation = new SignatureInformation
            //                {
            //                    ID = new ID { Value = "" },
            //                    ReferencedSignatureID = "",
            //                    Signature = new Signature
            //                    {
            //                        Id = "",
            //                        KeyInfo = new SignatureKeyInfo
            //                        {
            //                            X509Data = new SignatureKeyInfoX509Data
            //                            {
            //                                X509Certificate = ""
            //                            }
            //                        },
            //                        SignatureValue = "",
            //                        SignedInfo = new SignatureSignedInfo
            //                        {
            //                            CanonicalizationMethod = new SignatureSignedInfoCanonicalizationMethod
            //                            {
            //                                Algorithm = ""
            //                            },
            //                            Reference = new SignatureSignedInfoReference[]
            //                            {
            //                                new SignatureSignedInfoReference
            //                                {
            //                                    Id="",
            //                                    DigestValue="",
            //                                    URI="",
            //                                    Type="",
            //                                    DigestMethod=new SignatureSignedInfoReferenceDigestMethod
            //                                    {
            //                                        Algorithm=""
            //                                    },
            //                                    Transforms=new SignatureSignedInfoReferenceTransform[]
            //                                    {
            //                                        new SignatureSignedInfoReferenceTransform
            //                                        {
            //                                            Algorithm="",
            //                                            XPath=""
            //                                        }
            //                                    },
            //                                },
            //                            },
            //                            SignatureMethod = new SignatureSignedInfoSignatureMethod
            //                            {
            //                                Algorithm = ""
            //                            }
            //                        },
            //                        Object = new SignatureObject
            //                        {
            //                            QualifyingProperties = new QualifyingProperties
            //                            {
            //                                SignedProperties = new QualifyingPropertiesSignedProperties
            //                                {
            //                                    Id = "",
            //                                    SignedSignatureProperties = new QualifyingPropertiesSignedPropertiesSignedSignatureProperties
            //                                    {
            //                                        SigningCertificate = new QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificate
            //                                        {
            //                                            Cert = new QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCert
            //                                            {
            //                                                CertDigest = new QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertCertDigest
            //                                                {
            //                                                    DigestMethod = new DigestMethod
            //                                                    {
            //                                                        Algorithm = ""
            //                                                    },
            //                                                    DigestValue = ""
            //                                                },
            //                                                IssuerSerial = new QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertIssuerSerial
            //                                                {
            //                                                    X509IssuerName = "",
            //                                                    X509SerialNumber = 0
            //                                                }
            //                                            }
            //                                        },
            //                                    },
            //                                },
            //                                Target = "",
            //                            },
            //                        }
            //                    }
            //                },
            //            },
            //        },
            //        ExtensionURI = "",
            //    }
            //};
            //invoice.Signature = new Signature1
            //{
            //    ID = new ID { Value = "" },
            //    SignatureMethod = ""
            //};
            //invoice.AccountingSupplierParty = new AccountingSupplierParty
            //{
            //    Party = new AccountingSupplierPartyParty
            //    {
            //        PartyIdentification = new AccountingSupplierPartyPartyPartyIdentification
            //        {
            //            ID = new ID { Value = "QR",schemeID="ZZZ" },
            //        },
            //        PartyLegalEntity = new AccountingSupplierPartyPartyPartyLegalEntity
            //        {
            //            RegistrationName = "",
            //        },
            //        PartyTaxScheme = new AccountingSupplierPartyPartyPartyTaxScheme
            //        {
            //            CompanyID = "",
            //            TaxScheme = new AccountingSupplierPartyPartyPartyTaxSchemeTaxScheme
            //            {
            //                ID = new ID { Value = "" },
            //            },
            //        },
            //        PostalAddress = new AccountingSupplierPartyPartyPostalAddress
            //        {
            //            AdditionalStreetName = "",
            //            BuildingNumber = 0,
            //            CityName = "",
            //            CitySubdivisionName = "",
            //            Country = new AccountingSupplierPartyPartyPostalAddressCountry
            //            {
            //                IdentificationCode = ""
            //            },
            //            CountrySubentity = "",
            //            PlotIdentification = "",
            //            PostalZone = 0,
            //            StreetName = ""
            //        }
            //    }
            //};
            //invoice.AccountingCustomerParty = new AccountingCustomerParty
            //{
            //    Party = new AccountingCustomerPartyParty
            //    {
            //        PartyIdentification = new AccountingCustomerPartyPartyPartyIdentification
            //        {
            //            ID = new ID { Value = "" },
            //        },
            //        PartyLegalEntity = new AccountingCustomerPartyPartyPartyLegalEntity
            //        {
            //            RegistrationName = "",
            //        },
            //        PartyTaxScheme = new AccountingCustomerPartyPartyPartyTaxScheme
            //        {
            //            CompanyID = "",
            //            TaxScheme = new AccountingCustomerPartyPartyPartyTaxSchemeTaxScheme
            //            {
            //                ID = new ID { Value = "" },
            //            },
            //        },
            //        PostalAddress = new AccountingCustomerPartyPartyPostalAddress
            //        {
            //            AdditionalStreetName = "",
            //            BuildingNumber = 0,
            //            CityName = "",
            //            CitySubdivisionName = "",
            //            Country = new AccountingCustomerPartyPartyPostalAddressCountry
            //            {
            //                IdentificationCode = ""
            //            },
            //            CountrySubentity = "",
            //            PlotIdentification = "",
            //            PostalZone = 0,
            //            StreetName = ""
            //        },
            //    },
            //};
            //invoice.Delivery = new Delivery
            //{
            //    ActualDeliveryDate = DateTime.Now,
            //    LatestDeliveryDate = DateTime.Now
            //};
            //invoice.PaymentMeans = new PaymentMeans
            //{
            //    InstructionNote = "",
            //    PayeeFinancialAccount = new PaymentMeansPayeeFinancialAccount
            //    {
            //        ID = new ID { Value = "" },
            //        PaymentNote = "",
            //    },
            //    PaymentMeansCode = new PaymentMeansCode
            //    {
            //        listID = "",
            //        Value = 0
            //    }
            //};
            //invoice.AllowanceCharge = new AllowanceCharge
            //{
            //    Amount = new Amount
            //    {
            //        currencyID = "",
            //        Value = 0
            //    },
            //    BaseAmount = new BaseAmount()
            //    {
            //        currencyID = "",
            //        Value = 0
            //    },
            //    ChargeIndicator = true,
            //    MultiplierFactorNumeric = 0,
            //    TaxCategory = new AllowanceChargeTaxCategory
            //    {
            //        ID = new ID { Value = "" },
            //        Percent = 0,
            //        TaxScheme = new AllowanceChargeTaxCategoryTaxScheme
            //        {
            //            ID = new ID { Value = "" }
            //        }
            //    }
            //};
            //invoice.LegalMonetaryTotal = new LegalMonetaryTotal
            //{
            //    AllowanceTotalAmount = new AllowanceTotalAmount
            //    {
            //        currencyID = "",
            //        Value = 0
            //    },
            //    LineExtensionAmount = new LineExtensionAmount
            //    {
            //        currencyID = "",
            //        Value = 0
            //    },
            //    PayableAmount = new PayableAmount
            //    {
            //        currencyID = "",
            //        Value = 0
            //    },
            //    PrepaidAmount = new PrepaidAmount
            //    {
            //        currencyID = "",
            //        Value = 0
            //    },
            //    TaxExclusiveAmount = new TaxExclusiveAmount
            //    {
            //        currencyID = "",
            //        Value = 0
            //    },
            //    TaxInclusiveAmount = new TaxInclusiveAmount
            //    {
            //        currencyID = "",
            //        Value = 0
            //    },
            //};
            //invoice.TaxTotal = new TaxTotal
            //{
            //    TaxAmount = new TaxAmount
            //    {
            //        currencyID = "",
            //        Value = 0
            //    },
            //    TaxSubtotal = new TaxTotalTaxSubtotal
            //    {
            //        TaxAmount = new TaxAmount
            //        {
            //            currencyID = "",
            //            Value = 0
            //        },
            //        TaxableAmount = new TaxableAmount
            //        {
            //            currencyID = "",
            //            Value = 0
            //        },
            //        TaxCategory = new TaxTotalTaxSubtotalTaxCategory
            //        {
            //            ID = new ID { Value = "" },
            //            Percent = 0,
            //            TaxExemptionReason = "",
            //            TaxExemptionReasonCode = 0,
            //            TaxScheme = new TaxTotalTaxSubtotalTaxCategoryTaxScheme
            //            {
            //                ID = new ID { Value = "" }
            //            }
            //        },
            //    },
            //};
            //invoice.InvoiceLine = new InvoiceLine
            //{
            //    ID = new ID { Value = "" },
            //    AllowanceCharge = new InvoiceLineAllowanceCharge
            //    {
            //        Amount = new Amount
            //        {
            //            currencyID = "",
            //            Value = 0
            //        },
            //        BaseAmount = new BaseAmount
            //        {
            //            currencyID = "",
            //            Value = 0
            //        },
            //        ChargeIndicator = true,
            //        MultiplierFactorNumeric = 0
            //    },
            //    InvoicedQuantity = new InvoicedQuantity
            //    {
            //        unitCode = "",
            //        Value = 0
            //    },
            //    Item = new InvoiceLineItem
            //    {
            //        BuyersItemIdentification = new InvoiceLineItemBuyersItemIdentification
            //        {
            //            ID = new ID { Value = "" }
            //        },
            //        ClassifiedTaxCategory = new InvoiceLineItemClassifiedTaxCategory
            //        {
            //            ID = new ID { Value = "" },
            //            Percent = 0,
            //            TaxScheme = new InvoiceLineItemClassifiedTaxCategoryTaxScheme
            //            {
            //                ID = new ID { Value = "" }
            //            }
            //        },
            //        Name = "",
            //        SellersItemIdentification = new InvoiceLineItemSellersItemIdentification
            //        {
            //            ID = new ID { Value = "" }
            //        },
            //        StandardItemIdentification = new InvoiceLineItemStandardItemIdentification
            //        {
            //            ID = new ID { Value = "" }
            //        },
            //    },
            //    LineExtensionAmount = new LineExtensionAmount
            //    {
            //        currencyID = "",
            //        Value = 0
            //    },
            //    Price = new InvoiceLinePrice
            //    {
            //        AllowanceCharge = new InvoiceLinePriceAllowanceCharge
            //        {
            //            Amount = new Amount
            //            {
            //                currencyID = "",
            //                Value = 0
            //            },
            //            BaseAmount = new BaseAmount
            //            {
            //                currencyID = "",
            //                Value = 0
            //            },
            //            ChargeIndicator = true
            //        },
            //        BaseQuantity = new BaseQuantity
            //        {
            //            unitCode = "",
            //            Value = 0
            //        },
            //        PriceAmount = new PriceAmount
            //        {
            //            currencyID = "",
            //            Value = 0
            //        },
            //    },
            //    TaxTotal = new InvoiceLineTaxTotal
            //    {
            //        RoundingAmount = new RoundingAmount
            //        {
            //            currencyID = "",
            //            Value = 0
            //        },
            //        TaxAmount = new TaxAmount
            //        {
            //            currencyID = "",
            //            Value = 0
            //        }
            //    },
            //};
            //serializeSample.Serialize(xmlFileName, invoice);
            #endregion
            //Entity = serializeSample.Deserialize(xmlFileName, Entity);
            #region XML Compare
            XNamespace ns = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2";
            XDocument doc = XDocument.Load(xmlFileName + "XML Test.xml");
            XDocument doc2 = XDocument.Load(xmlFileName + "sample.xml");
            IEnumerable<XElement> elementsDifferent = from xmlElement in doc.Root.Descendants()
                                                      where !(from simmpleElement in doc2.Root.Descendants()
                                                              select simmpleElement.Name.ToString()).Contains(xmlElement.Name.ToString())
                                                      select xmlElement;
            IEnumerable<XElement> elementsRepeated = (from xmlElement in doc.Root.Descendants()
                                                      group xmlElement by xmlElement.Name into x
                                                      select x.First());
            foreach (XElement element in elementsRepeated)
            {
                if (doc.Root.Descendants(element.Name.ToString()).Count() > 1 && doc.Root.Descendants(element.Name.ToString()).Attributes().Count() > 0)
                    foreach (var item in doc.Root.Descendants(element.Name.ToString()))
                    {
                        string path = string.Join("/", item.Ancestors().Select(e => e.Name.LocalName).Reverse());
                        Console.WriteLine(path + "/" + item.Name.LocalName);
                        foreach (XAttribute i in item.Attributes())
                        {
                            Console.WriteLine(i);
                        }
                    }
            }
            #endregion
        }
    }
}
