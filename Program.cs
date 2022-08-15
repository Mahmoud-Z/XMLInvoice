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
            string xmlFileName = @"Test\";
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
            Invoice invoice = new Invoice();
            invoice.ProfileID = "";
            invoice.ID = "test";
            invoice.UUID = "";
            invoice.InvoiceTypeCode = new InvoiceTypeCode
            {
                Value = 0
            };
            invoice.Note = "";
            invoice.DocumentCurrencyCode = "";
            invoice.TaxCurrencyCode = "";
            invoice.OrderReference = new OrderReference
            {
                ID = "test"
            };
            invoice.BillingReference = new BillingReference
            {
                InvoiceDocumentReference = new BillingReferenceInvoiceDocumentReference
                {
                    ID = "test"
                }
            };
            invoice.ContractDocumentReference = new ContractDocumentReference
            {
                ID = "test"
            };
            invoice.AdditionalDocumentReference = new AdditionalDocumentReference[]
            {
                new AdditionalDocumentReference
                {
                    ID= "test",
                    UUID="",
                },
                new AdditionalDocumentReference
                {
                    ID= "test",
                    Attachment=new AdditionalDocumentReferenceAttachment
                    {
                        EmbeddedDocumentBinaryObject=new EmbeddedDocumentBinaryObject
                        {
                            Value=""
                        }
                    },
                },
                new AdditionalDocumentReference
                {
                    ID= "test",
                    Attachment=new AdditionalDocumentReferenceAttachment
                    {
                        EmbeddedDocumentBinaryObject=new EmbeddedDocumentBinaryObject
                        {
                            Value=""
                        }
                    },
                },
            };
            invoice.UBLExtensions = new UBLExtensions
            {
                UBLExtension = new UBLExtensionsUBLExtension
                {
                    ExtensionContent = new UBLExtensionsUBLExtensionExtensionContent
                    {
                        UBLDocumentSignatures = new UBLDocumentSignatures
                        {
                            SignatureInformation = new SignatureInformation
                            {
                                ID = "test",
                                ReferencedSignatureID = "",
                                Signature = new Signature
                                {
                                    Id = "",
                                    KeyInfo = new SignatureKeyInfo
                                    {
                                        X509Data = new SignatureKeyInfoX509Data
                                        {
                                            X509Certificate = ""
                                        }
                                    },
                                    SignatureValue = "",
                                    SignedInfo = new SignatureSignedInfo
                                    {
                                        CanonicalizationMethod = new SignatureSignedInfoCanonicalizationMethod
                                        {
                                            Algorithm = ""
                                        },
                                        Reference = new SignatureSignedInfoReference[]
                                        {
                                            new SignatureSignedInfoReference
                                            {
                                                Id="",
                                                DigestValue="",
                                                URI="",
                                                Type="",
                                                DigestMethod=new SignatureSignedInfoReferenceDigestMethod
                                                {
                                                    Algorithm=""
                                                },
                                                Transforms=new SignatureSignedInfoReferenceTransform[]
                                                {
                                                    new SignatureSignedInfoReferenceTransform
                                                    {
                                                        Algorithm="",
                                                        XPath=""
                                                    }
                                                },
                                            },
                                        },
                                        SignatureMethod = new SignatureSignedInfoSignatureMethod
                                        {
                                            Algorithm = ""
                                        }
                                    },
                                    Object = new SignatureObject
                                    {
                                        QualifyingProperties = new QualifyingProperties
                                        {
                                            SignedProperties = new QualifyingPropertiesSignedProperties
                                            {
                                                Id = "",
                                                SignedSignatureProperties = new QualifyingPropertiesSignedPropertiesSignedSignatureProperties
                                                {
                                                    SigningCertificate = new QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificate
                                                    {
                                                        Cert = new QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCert
                                                        {
                                                            CertDigest = new QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertCertDigest
                                                            {
                                                                DigestMethod = new DigestMethod
                                                                {
                                                                    Algorithm = ""
                                                                },
                                                                DigestValue = ""
                                                            },
                                                            IssuerSerial = new QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertIssuerSerial
                                                            {
                                                                X509IssuerName = "",
                                                                X509SerialNumber = 0
                                                            }
                                                        }
                                                    },
                                                },
                                            },
                                            Target = "",
                                        },
                                    }
                                }
                            },
                        },
                    },
                    ExtensionURI = "",
                }
            };
            invoice.Signature = new Signature1
            {
                ID = "test",
                SignatureMethod = ""
            };
            invoice.AccountingSupplierParty = new AccountingSupplierParty
            {
                Party = new AccountingSupplierPartyParty
                {
                    PartyIdentification = new AccountingSupplierPartyPartyPartyIdentification
                    {
                        ID = "test",
                    },
                    PartyLegalEntity = new AccountingSupplierPartyPartyPartyLegalEntity
                    {
                        RegistrationName = "",
                    },
                    PartyTaxScheme = new AccountingSupplierPartyPartyPartyTaxScheme
                    {
                        CompanyID = "",
                        TaxScheme = new AccountingSupplierPartyPartyPartyTaxSchemeTaxScheme
                        {
                            ID = "test",
                        },
                    },
                    PostalAddress = new AccountingSupplierPartyPartyPostalAddress
                    {
                        AdditionalStreetName = "",
                        BuildingNumber = 0,
                        CityName = "",
                        CitySubdivisionName = "",
                        Country = new AccountingSupplierPartyPartyPostalAddressCountry
                        {
                            IdentificationCode = ""
                        },
                        CountrySubentity = "",
                        PlotIdentification = "",
                        PostalZone = 0,
                        StreetName = ""
                    }
                }
            };
            invoice.AccountingCustomerParty = new AccountingCustomerParty
            {
                Party = new AccountingCustomerPartyParty
                {
                    PartyIdentification = new AccountingCustomerPartyPartyPartyIdentification
                    {
                        ID = new ID { Value = "" },
                    },
                    PartyLegalEntity = new AccountingCustomerPartyPartyPartyLegalEntity
                    {
                        RegistrationName = "",
                    },
                    PartyTaxScheme = new AccountingCustomerPartyPartyPartyTaxScheme
                    {
                        CompanyID = "",
                        TaxScheme = new AccountingCustomerPartyPartyPartyTaxSchemeTaxScheme
                        {
                            ID = "test",
                        },
                    },
                    PostalAddress = new AccountingCustomerPartyPartyPostalAddress
                    {
                        AdditionalStreetName = "",
                        BuildingNumber = 0,
                        CityName = "",
                        CitySubdivisionName = "",
                        Country = new AccountingCustomerPartyPartyPostalAddressCountry
                        {
                            IdentificationCode = ""
                        },
                        CountrySubentity = "",
                        PlotIdentification = "",
                        PostalZone = 0,
                        StreetName = ""
                    },
                },
            };
            invoice.Delivery = new Delivery
            {
                ActualDeliveryDate = DateTime.Now,
                LatestDeliveryDate = DateTime.Now
            };
            invoice.PaymentMeans = new PaymentMeans
            {
                InstructionNote = "",
                PayeeFinancialAccount = new PaymentMeansPayeeFinancialAccount
                {
                    ID = "test",
                    PaymentNote = "",
                },
                PaymentMeansCode = new PaymentMeansCode
                {
                    listID = "",
                    Value = 0
                }
            };
            invoice.AllowanceCharge = new AllowanceCharge
            {
                Amount = new Amount
                {
                    currencyID = "",
                    Value = 0
                },
                BaseAmount = new BaseAmount()
                {
                    currencyID = "",
                    Value = 0
                },
                ChargeIndicator = true,
                MultiplierFactorNumeric = 0,
                TaxCategory = new AllowanceChargeTaxCategory
                {
                    ID = "test",
                    Percent = 0,
                    TaxScheme = new AllowanceChargeTaxCategoryTaxScheme
                    {
                        ID = "test"
                    }
                }
            };
            invoice.LegalMonetaryTotal = new LegalMonetaryTotal
            {
                AllowanceTotalAmount = new AllowanceTotalAmount
                {
                    currencyID = "",
                    Value = 0
                },
                LineExtensionAmount = new LineExtensionAmount
                {
                    currencyID = "",
                    Value = 0
                },
                PayableAmount = new PayableAmount
                {
                    currencyID = "",
                    Value = 0
                },
                PrepaidAmount = new PrepaidAmount
                {
                    currencyID = "",
                    Value = 0
                },
                TaxExclusiveAmount = new TaxExclusiveAmount
                {
                    currencyID = "",
                    Value = 0
                },
                TaxInclusiveAmount = new TaxInclusiveAmount
                {
                    currencyID = "",
                    Value = 0
                },
            };
            invoice.TaxTotal = new TaxTotal
            {
                TaxAmount = new TaxAmount
                {
                    currencyID = "",
                    Value = 0
                },
                TaxSubtotal = new TaxTotalTaxSubtotal
                {
                    TaxAmount = new TaxAmount
                    {
                        currencyID = "",
                        Value = 0
                    },
                    TaxableAmount = new TaxableAmount
                    {
                        currencyID = "",
                        Value = 0
                    },
                    TaxCategory = new TaxTotalTaxSubtotalTaxCategory
                    {
                        ID = new ID { Value = "" },
                        Percent = 0,
                        TaxExemptionReason = "",
                        TaxExemptionReasonCode = 0,
                        TaxScheme = new TaxTotalTaxSubtotalTaxCategoryTaxScheme
                        {
                            ID = "test"
                        }
                    },
                },
            };
            invoice.InvoiceLine = new InvoiceLine
            {
                ID = "test",
                AllowanceCharge = new InvoiceLineAllowanceCharge
                {
                    Amount = new Amount
                    {
                        currencyID = "",
                        Value = 0
                    },
                    BaseAmount = new BaseAmount
                    {
                        currencyID = "",
                        Value = 0
                    },
                    ChargeIndicator = true,
                    MultiplierFactorNumeric = 0
                },
                InvoicedQuantity = new InvoicedQuantity
                {
                    unitCode = "",
                    Value = 0
                },
                Item = new InvoiceLineItem
                {
                    BuyersItemIdentification = new InvoiceLineItemBuyersItemIdentification
                    {
                        ID = "test"
                    },
                    ClassifiedTaxCategory = new InvoiceLineItemClassifiedTaxCategory
                    {
                        ID = new ID { Value = "" },
                        Percent = 0,
                        TaxScheme = new InvoiceLineItemClassifiedTaxCategoryTaxScheme
                        {
                            ID = new ID { Value = "" }
                        }
                    },
                    Name = "",
                    SellersItemIdentification = new InvoiceLineItemSellersItemIdentification
                    {
                        ID = "test"
                    },
                    StandardItemIdentification = new InvoiceLineItemStandardItemIdentification
                    {
                        ID = new ID { Value = "" }
                    },
                },
                LineExtensionAmount = new LineExtensionAmount
                {
                    currencyID = "",
                    Value = 0
                },
                Price = new InvoiceLinePrice
                {
                    AllowanceCharge = new InvoiceLinePriceAllowanceCharge
                    {
                        Amount = new Amount
                        {
                            currencyID = "",
                            Value = 0
                        },
                        BaseAmount = new BaseAmount
                        {
                            currencyID = "",
                            Value = 0
                        },
                        ChargeIndicator = true
                    },
                    BaseQuantity = new BaseQuantity
                    {
                        unitCode = "",
                        Value = 0
                    },
                    PriceAmount = new PriceAmount
                    {
                        currencyID = "",
                        Value = 0
                    },
                },
                TaxTotal = new InvoiceLineTaxTotal
                {
                    RoundingAmount = new RoundingAmount
                    {
                        currencyID = "",
                        Value = 0
                    },
                    TaxAmount = new TaxAmount
                    {
                        currencyID = "",
                        Value = 0
                    }
                },
            };
            serializeSample.Serialize(xmlFileName, invoice, "Credit");
            #endregion
            //Entity = serializeSample.Deserialize(xmlFileName, Entity);
            #region XML Compare
            //XNamespace ns = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2";
            //XNamespace ns = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2";
            //XDocument doc = XDocument.Load(xmlFileName + "XML Test.xml");
            //XDocument doc2 = XDocument.Load(xmlFileName + "sample.xml");
            //IEnumerable<XElement> elementsDifferent = from xmlElement in doc.Root.Descendants()
            //                                          where !(from simmpleElement in doc2.Root.Descendants()
            //                                                  select simmpleElement.Name.ToString()).Contains(xmlElement.Name.ToString())
            //                                          select xmlElement;
            //IEnumerable<XElement> elementsRepeated = (from xmlElement in doc.Root.Descendants()
            //                                          group xmlElement by xmlElement.Name into x
            //                                          select x.First());
            //foreach (XElement element in elementsRepeated)
            //{
            //    if (doc.Root.Descendants(element.Name.ToString()).Count() > 1 && doc.Root.Descendants(element.Name.ToString()).Attributes().Count() > 0)
            //        foreach (var item in doc.Root.Descendants(element.Name.ToString()))
            //        {
            //            string path = string.Join("/", item.Ancestors().Select(e => e.Name.LocalName).Reverse());
            //            Console.WriteLine(path + "/" + item.Name.LocalName);
            //            foreach (XAttribute i in item.Attributes())
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }
            //}
            #endregion
            #region XML herirachey Compare
            //XNamespace ns = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2";
            //XDocument doc = XDocument.Load(xmlFileName + "XML Test.xml");
            //XDocument doc2 = XDocument.Load(xmlFileName + "sample.xml");
            //#region check xml structure
            //var elementsJoined = (from xmlElement in doc.Root.Descendants()
            //                        join simmpleElement in doc2.Root.Descendants()
            //                        on new
            //                        {
            //                            Ancestors = string.Join("/", xmlElement.Ancestors().Select(e => e.Name.LocalName).Reverse()),
            //                            name = xmlElement.Name.LocalName
            //                        } equals new
            //                        {
            //                            Ancestors = string.Join("/", simmpleElement.Ancestors().Select(e => e.Name.LocalName).Reverse()),
            //                            name = simmpleElement.Name.LocalName
            //                        }
            //                        select new
            //                        {
            //                            Ancestors = string.Join("/", xmlElement.Ancestors().Select(e => e.Name.LocalName).Reverse()),
            //                            name = xmlElement.Name.LocalName
            //                        });
            //var XMLDifferences = (from xmlElement in doc.Root.Descendants()
            //                      where !elementsJoined.Contains(new
            //                      {
            //                          Ancestors = string.Join("/", xmlElement.Ancestors().Select(e => e.Name.LocalName).Reverse()),
            //                          name = xmlElement.Name.LocalName
            //                      })
            //                      select new
            //                      {
            //                          Ancestors = string.Join("/", xmlElement.Ancestors().Select(e => e.Name.LocalName).Reverse()),
            //                          name = xmlElement.Name.LocalName
            //                      });
            //#endregion
            //#region check the difference in tags
            //var repeatedElements = (from originalElement in doc.Root.Descendants()
            //                       join newElement in doc2.Root.Descendants()
            //                       on new
            //                       {
            //                           count = doc.Root.Descendants(originalElement.Name).Count(),
            //                           name = originalElement.Name.LocalName
            //                       } equals new
            //                       {
            //                           count = doc2.Root.Descendants(newElement.Name).Count(),
            //                           name = newElement.Name.LocalName
            //                       }
            //                       select new
            //                       {
            //                           count = doc.Root.Descendants(originalElement.Name).Count(),
            //                           name = originalElement.Name.LocalName
            //                       }).Distinct();
            //var inOrginalNotInNew = (from xmlElement in doc.Root.Descendants()
            //                         where !repeatedElements.Contains(new
            //                         {
            //                             count = doc.Root.Descendants(xmlElement.Name).Count(),
            //                             name = xmlElement.Name.LocalName
            //                         })
            //                         select new
            //                         {
            //                             count = doc.Root.Descendants(xmlElement.Name).Count(),
            //                             name = xmlElement.Name.LocalName
            //                         }).Distinct();
            //var inNewNotInOrginal = (from xmlElement in doc2.Root.Descendants()
            //                         where !repeatedElements.Contains(new
            //                         {
            //                             count = doc2.Root.Descendants(xmlElement.Name).Count(),
            //                             name = xmlElement.Name.LocalName
            //                         })
            //                         select new
            //                         {
            //                             count = doc2.Root.Descendants(xmlElement.Name).Count(),
            //                             name = xmlElement.Name.LocalName
            //                         }).Distinct();
            //#endregion
            //var XMLRepeatedDifferences =from originalDifference in inOrginalNotInNew
            //                      join newDifference in inNewNotInOrginal
            //                      on originalDifference.name equals newDifference.name
            //                      select new
            //                      {
            //                           firstCount= originalDifference.count,
            //                           secondCount= newDifference.count,
            //                           name= originalDifference.name
            //                      };
            //foreach (var element in XMLRepeatedDifferences)
            //{
            //    Console.WriteLine("XML Original: " + element.firstCount);
            //    Console.WriteLine("XML New: " + element.secondCount);
            //    Console.WriteLine("XML Name: " + element.name);
            //}
            //Console.WriteLine(doc.Root.Descendants().Count());
            //Console.WriteLine(doc2.Root.Descendants().Count());
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
                        //Console.WriteLine(path + "/" + item.Name.LocalName);
                        foreach (XAttribute i in item.Attributes())
                        {
                            //Console.WriteLine(i);
                        }
                    }
            }

            List<string> tags = new List<string>();

            foreach (XElement element in elementsRepeated)
            {
                var tag = element.Name.ToString();
                var tagSimpl = element.Name.LocalName.ToString();
                var descendants = doc.Root.Descendants(tag);
                var descendantsCount = descendants.Count();

                if (descendantsCount > 1 /*&& descendants.Attributes().Count() > 0*/)
                {
                    var parents = descendants.Select(e => e.Parent).Distinct();
                    if(descendantsCount > parents.Count())
                    {
                        //get sibling
                        var duplicatedParents = descendants.GroupBy(e => e.Parent.Name)
                                .Where(g => g.Count() > 1)
                                .Select(g => g.Key);

                        foreach (var item in duplicatedParents)
                        {
                            Console.WriteLine($"Tag: {tagSimpl} & Parent: {item}");
                        }
                    }

                    //if (descendants.Any(e => e.Attributes().Count() == 0))
                    //{
                    //    tags.Add(tag);
                    //}
                }


            }

            #region Comments
            //foreach (var item in tags)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            Console.ReadKey();
        }
    }
}
