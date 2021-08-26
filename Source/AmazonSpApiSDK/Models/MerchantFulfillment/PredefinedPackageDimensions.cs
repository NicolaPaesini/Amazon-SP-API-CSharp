/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace AmazonSpApiSDK.Models.MerchantFulfillment
{
    /// <summary>
    /// An enumeration of predefined parcel tokens. If you specify a PredefinedPackageDimensions token, you are not obligated to use a branded package from a carrier. For example, if you specify the FedEx_Box_10kg token, you do not have to use that particular package from FedEx. You are only obligated to use a box that matches the dimensions specified by the token.  Note: Please note that carriers can have restrictions on the type of package allowed for certain ship methods. Check the carrier website for all details. Example: Flat rate pricing is available when materials are sent by USPS in a USPS-produced Flat Rate Envelope or Box.
    /// </summary>
    /// <value>An enumeration of predefined parcel tokens. If you specify a PredefinedPackageDimensions token, you are not obligated to use a branded package from a carrier. For example, if you specify the FedEx_Box_10kg token, you do not have to use that particular package from FedEx. You are only obligated to use a box that matches the dimensions specified by the token.  Note: Please note that carriers can have restrictions on the type of package allowed for certain ship methods. Check the carrier website for all details. Example: Flat rate pricing is available when materials are sent by USPS in a USPS-produced Flat Rate Envelope or Box.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum PredefinedPackageDimensions
    {

        /// <summary>
        /// Enum FedExBox10kg for value: FedEx_Box_10kg
        /// </summary>
        [EnumMember(Value = "FedEx_Box_10kg")]
        FedExBox10kg = 1,

        /// <summary>
        /// Enum FedExBox25kg for value: FedEx_Box_25kg
        /// </summary>
        [EnumMember(Value = "FedEx_Box_25kg")]
        FedExBox25kg = 2,

        /// <summary>
        /// Enum FedExBoxExtraLarge1 for value: FedEx_Box_Extra_Large_1
        /// </summary>
        [EnumMember(Value = "FedEx_Box_Extra_Large_1")]
        FedExBoxExtraLarge1 = 3,

        /// <summary>
        /// Enum FedExBoxExtraLarge2 for value: FedEx_Box_Extra_Large_2
        /// </summary>
        [EnumMember(Value = "FedEx_Box_Extra_Large_2")]
        FedExBoxExtraLarge2 = 4,

        /// <summary>
        /// Enum FedExBoxLarge1 for value: FedEx_Box_Large_1
        /// </summary>
        [EnumMember(Value = "FedEx_Box_Large_1")]
        FedExBoxLarge1 = 5,

        /// <summary>
        /// Enum FedExBoxLarge2 for value: FedEx_Box_Large_2
        /// </summary>
        [EnumMember(Value = "FedEx_Box_Large_2")]
        FedExBoxLarge2 = 6,

        /// <summary>
        /// Enum FedExBoxMedium1 for value: FedEx_Box_Medium_1
        /// </summary>
        [EnumMember(Value = "FedEx_Box_Medium_1")]
        FedExBoxMedium1 = 7,

        /// <summary>
        /// Enum FedExBoxMedium2 for value: FedEx_Box_Medium_2
        /// </summary>
        [EnumMember(Value = "FedEx_Box_Medium_2")]
        FedExBoxMedium2 = 8,

        /// <summary>
        /// Enum FedExBoxSmall1 for value: FedEx_Box_Small_1
        /// </summary>
        [EnumMember(Value = "FedEx_Box_Small_1")]
        FedExBoxSmall1 = 9,

        /// <summary>
        /// Enum FedExBoxSmall2 for value: FedEx_Box_Small_2
        /// </summary>
        [EnumMember(Value = "FedEx_Box_Small_2")]
        FedExBoxSmall2 = 10,

        /// <summary>
        /// Enum FedExEnvelope for value: FedEx_Envelope
        /// </summary>
        [EnumMember(Value = "FedEx_Envelope")]
        FedExEnvelope = 11,

        /// <summary>
        /// Enum FedExPaddedPak for value: FedEx_Padded_Pak
        /// </summary>
        [EnumMember(Value = "FedEx_Padded_Pak")]
        FedExPaddedPak = 12,

        /// <summary>
        /// Enum FedExPak1 for value: FedEx_Pak_1
        /// </summary>
        [EnumMember(Value = "FedEx_Pak_1")]
        FedExPak1 = 13,

        /// <summary>
        /// Enum FedExPak2 for value: FedEx_Pak_2
        /// </summary>
        [EnumMember(Value = "FedEx_Pak_2")]
        FedExPak2 = 14,

        /// <summary>
        /// Enum FedExTube for value: FedEx_Tube
        /// </summary>
        [EnumMember(Value = "FedEx_Tube")]
        FedExTube = 15,

        /// <summary>
        /// Enum FedExXLPak for value: FedEx_XL_Pak
        /// </summary>
        [EnumMember(Value = "FedEx_XL_Pak")]
        FedExXLPak = 16,

        /// <summary>
        /// Enum UPSBox10kg for value: UPS_Box_10kg
        /// </summary>
        [EnumMember(Value = "UPS_Box_10kg")]
        UPSBox10kg = 17,

        /// <summary>
        /// Enum UPSBox25kg for value: UPS_Box_25kg
        /// </summary>
        [EnumMember(Value = "UPS_Box_25kg")]
        UPSBox25kg = 18,

        /// <summary>
        /// Enum UPSExpressBox for value: UPS_Express_Box
        /// </summary>
        [EnumMember(Value = "UPS_Express_Box")]
        UPSExpressBox = 19,

        /// <summary>
        /// Enum UPSExpressBoxLarge for value: UPS_Express_Box_Large
        /// </summary>
        [EnumMember(Value = "UPS_Express_Box_Large")]
        UPSExpressBoxLarge = 20,

        /// <summary>
        /// Enum UPSExpressBoxMedium for value: UPS_Express_Box_Medium
        /// </summary>
        [EnumMember(Value = "UPS_Express_Box_Medium")]
        UPSExpressBoxMedium = 21,

        /// <summary>
        /// Enum UPSExpressBoxSmall for value: UPS_Express_Box_Small
        /// </summary>
        [EnumMember(Value = "UPS_Express_Box_Small")]
        UPSExpressBoxSmall = 22,

        /// <summary>
        /// Enum UPSExpressEnvelope for value: UPS_Express_Envelope
        /// </summary>
        [EnumMember(Value = "UPS_Express_Envelope")]
        UPSExpressEnvelope = 23,

        /// <summary>
        /// Enum UPSExpressHardPak for value: UPS_Express_Hard_Pak
        /// </summary>
        [EnumMember(Value = "UPS_Express_Hard_Pak")]
        UPSExpressHardPak = 24,

        /// <summary>
        /// Enum UPSExpressLegalEnvelope for value: UPS_Express_Legal_Envelope
        /// </summary>
        [EnumMember(Value = "UPS_Express_Legal_Envelope")]
        UPSExpressLegalEnvelope = 25,

        /// <summary>
        /// Enum UPSExpressPak for value: UPS_Express_Pak
        /// </summary>
        [EnumMember(Value = "UPS_Express_Pak")]
        UPSExpressPak = 26,

        /// <summary>
        /// Enum UPSExpressTube for value: UPS_Express_Tube
        /// </summary>
        [EnumMember(Value = "UPS_Express_Tube")]
        UPSExpressTube = 27,

        /// <summary>
        /// Enum UPSLaboratoryPak for value: UPS_Laboratory_Pak
        /// </summary>
        [EnumMember(Value = "UPS_Laboratory_Pak")]
        UPSLaboratoryPak = 28,

        /// <summary>
        /// Enum UPSPadPak for value: UPS_Pad_Pak
        /// </summary>
        [EnumMember(Value = "UPS_Pad_Pak")]
        UPSPadPak = 29,

        /// <summary>
        /// Enum UPSPallet for value: UPS_Pallet
        /// </summary>
        [EnumMember(Value = "UPS_Pallet")]
        UPSPallet = 30,

        /// <summary>
        /// Enum USPSCard for value: USPS_Card
        /// </summary>
        [EnumMember(Value = "USPS_Card")]
        USPSCard = 31,

        /// <summary>
        /// Enum USPSFlat for value: USPS_Flat
        /// </summary>
        [EnumMember(Value = "USPS_Flat")]
        USPSFlat = 32,

        /// <summary>
        /// Enum USPSFlatRateCardboardEnvelope for value: USPS_FlatRateCardboardEnvelope
        /// </summary>
        [EnumMember(Value = "USPS_FlatRateCardboardEnvelope")]
        USPSFlatRateCardboardEnvelope = 33,

        /// <summary>
        /// Enum USPSFlatRateEnvelope for value: USPS_FlatRateEnvelope
        /// </summary>
        [EnumMember(Value = "USPS_FlatRateEnvelope")]
        USPSFlatRateEnvelope = 34,

        /// <summary>
        /// Enum USPSFlatRateGiftCardEnvelope for value: USPS_FlatRateGiftCardEnvelope
        /// </summary>
        [EnumMember(Value = "USPS_FlatRateGiftCardEnvelope")]
        USPSFlatRateGiftCardEnvelope = 35,

        /// <summary>
        /// Enum USPSFlatRateLegalEnvelope for value: USPS_FlatRateLegalEnvelope
        /// </summary>
        [EnumMember(Value = "USPS_FlatRateLegalEnvelope")]
        USPSFlatRateLegalEnvelope = 36,

        /// <summary>
        /// Enum USPSFlatRatePaddedEnvelope for value: USPS_FlatRatePaddedEnvelope
        /// </summary>
        [EnumMember(Value = "USPS_FlatRatePaddedEnvelope")]
        USPSFlatRatePaddedEnvelope = 37,

        /// <summary>
        /// Enum USPSFlatRateWindowEnvelope for value: USPS_FlatRateWindowEnvelope
        /// </summary>
        [EnumMember(Value = "USPS_FlatRateWindowEnvelope")]
        USPSFlatRateWindowEnvelope = 38,

        /// <summary>
        /// Enum USPSLargeFlatRateBoardGameBox for value: USPS_LargeFlatRateBoardGameBox
        /// </summary>
        [EnumMember(Value = "USPS_LargeFlatRateBoardGameBox")]
        USPSLargeFlatRateBoardGameBox = 39,

        /// <summary>
        /// Enum USPSLargeFlatRateBox for value: USPS_LargeFlatRateBox
        /// </summary>
        [EnumMember(Value = "USPS_LargeFlatRateBox")]
        USPSLargeFlatRateBox = 40,

        /// <summary>
        /// Enum USPSLetter for value: USPS_Letter
        /// </summary>
        [EnumMember(Value = "USPS_Letter")]
        USPSLetter = 41,

        /// <summary>
        /// Enum USPSMediumFlatRateBox1 for value: USPS_MediumFlatRateBox1
        /// </summary>
        [EnumMember(Value = "USPS_MediumFlatRateBox1")]
        USPSMediumFlatRateBox1 = 42,

        /// <summary>
        /// Enum USPSMediumFlatRateBox2 for value: USPS_MediumFlatRateBox2
        /// </summary>
        [EnumMember(Value = "USPS_MediumFlatRateBox2")]
        USPSMediumFlatRateBox2 = 43,

        /// <summary>
        /// Enum USPSRegionalRateBoxA1 for value: USPS_RegionalRateBoxA1
        /// </summary>
        [EnumMember(Value = "USPS_RegionalRateBoxA1")]
        USPSRegionalRateBoxA1 = 44,

        /// <summary>
        /// Enum USPSRegionalRateBoxA2 for value: USPS_RegionalRateBoxA2
        /// </summary>
        [EnumMember(Value = "USPS_RegionalRateBoxA2")]
        USPSRegionalRateBoxA2 = 45,

        /// <summary>
        /// Enum USPSRegionalRateBoxB1 for value: USPS_RegionalRateBoxB1
        /// </summary>
        [EnumMember(Value = "USPS_RegionalRateBoxB1")]
        USPSRegionalRateBoxB1 = 46,

        /// <summary>
        /// Enum USPSRegionalRateBoxB2 for value: USPS_RegionalRateBoxB2
        /// </summary>
        [EnumMember(Value = "USPS_RegionalRateBoxB2")]
        USPSRegionalRateBoxB2 = 47,

        /// <summary>
        /// Enum USPSRegionalRateBoxC for value: USPS_RegionalRateBoxC
        /// </summary>
        [EnumMember(Value = "USPS_RegionalRateBoxC")]
        USPSRegionalRateBoxC = 48,

        /// <summary>
        /// Enum USPSSmallFlatRateBox for value: USPS_SmallFlatRateBox
        /// </summary>
        [EnumMember(Value = "USPS_SmallFlatRateBox")]
        USPSSmallFlatRateBox = 49,

        /// <summary>
        /// Enum USPSSmallFlatRateEnvelope for value: USPS_SmallFlatRateEnvelope
        /// </summary>
        [EnumMember(Value = "USPS_SmallFlatRateEnvelope")]
        USPSSmallFlatRateEnvelope = 50
    }

}