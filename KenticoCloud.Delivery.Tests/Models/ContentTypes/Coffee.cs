// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace KenticoCloud.Delivery.Tests
{
    public partial class Coffee
    {
        public const string Codename = "coffee";
        public const string ProductNameCodename = "product_name";
        public const string PriceCodename = "price";
        public const string ImageCodename = "image";
        public const string ShortDescriptionCodename = "short_description";
        public const string LongDescriptionCodename = "long_description";
        public const string ProductStatusCodename = "product_status";
        public const string FarmCodename = "farm";
        public const string CountryCodename = "country";
        public const string VarietyCodename = "variety";
        public const string ProcessingCodename = "processing";
        public const string AltitudeCodename = "altitude";
        public const string UrlPatternCodename = "url_pattern";

        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public IEnumerable<Asset> Image { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public IEnumerable<TaxonomyTerm> ProductStatus { get; set; }
        public string Farm { get; set; }
        public string Country { get; set; }
        public string Variety { get; set; }
        public IEnumerable<MultipleChoiceOption> Processing { get; set; }
        public string Altitude { get; set; }
        public string UrlPattern { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}