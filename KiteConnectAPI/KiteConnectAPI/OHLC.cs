﻿/*
        ARTHACHITRA MAKES NO REPRESENTATION ABOUT THE SUITABILITY OF THIS SOURCE CODE FOR ANY 
        PURPOSE. IT IS PROVIDED "AS IS" WITHOUT EXPRESS OR IMPLIED WARRANTY OF ANY KIND. ARTHACHITRA DISCLAIMS ALL WARRANTIES WITH REGARD TO THIS SOURCE CODE, 
        INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY, NON-INFRINGEMENT, AND FITNESS FOR A PARTICULAR PURPOSE. IN NO EVENT SHALL ARTHACHITRA BE LIABLE FOR ANY 
        SPECIAL, INDIRECT, INCEDENTAL, OR CONSEQUENTIAL DAMAGES, OR ANY DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION, ARISING 
        OUT OF OR IN CONNECTION WITH THE USE OR PERFORMACE OF THIS SOURCE CODE.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace KiteConnectAPI
{
    [DataContract]
    public class OHLC
    {
        /// <summary>
        /// Gets or sets the price at market opening
        /// </summary>
        [DataMember(Name = "open")]
        public double open { get; set; }

        /// <summary>
        /// Gets or sets the highest price today
        /// </summary>
        [DataMember(Name = "high")]
        public double high { get; set; }

        /// <summary>
        /// Gets or sets the lowest price today
        /// </summary>
        [DataMember(Name = "low")]
        public double low { get; set; }

        /// <summary>
        /// Gets or sets the closing price of the instrument from the last trading day
        /// </summary>
        [DataMember(Name = "close")]
        public double close { get; set; }

    }
}
