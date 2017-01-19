﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

namespace KenticoCloud.Deliver
{
    /// <summary>
    /// Represents type listing response from the API.
    /// </summary>
    public class DeliverTypeListingResponse
    {
        /// <summary>
        /// Content items.
        /// </summary>
        public List<ContentType> Types { get; set; }

        /// <summary>
        /// Contains paging information.
        /// </summary>
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Initializes response object.
        /// </summary>
        /// <param name="response">JSON returned from API.</param>
        public DeliverTypeListingResponse(JToken response)
        {
            Types = ((JArray)response["types"]).Select(x => new ContentType(x)).ToList();
            Pagination = new Pagination(response["pagination"]);
        }
    }
}
