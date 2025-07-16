using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMudBlazor.Helpers
{


    internal class ForecastCall
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class root
        {

            private rootLocation locationField;

            private rootCurrent currentField;

            /// <remarks/>
            public rootLocation location
            {
                get
                {
                    return this.locationField;
                }
                set
                {
                    this.locationField = value;
                }
            }

            /// <remarks/>
            public rootCurrent current
            {
                get
                {
                    return this.currentField;
                }
                set
                {
                    this.currentField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rootLocation
        {

            private string nameField;

            private string regionField;

            private string countryField;

            private decimal latField;

            private decimal lonField;

            private string tz_idField;

            private uint localtime_epochField;

            private string localtimeField;

            /// <remarks/>
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
            public string region
            {
                get
                {
                    return this.regionField;
                }
                set
                {
                    this.regionField = value;
                }
            }

            /// <remarks/>
            public string country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            public decimal lat
            {
                get
                {
                    return this.latField;
                }
                set
                {
                    this.latField = value;
                }
            }

            /// <remarks/>
            public decimal lon
            {
                get
                {
                    return this.lonField;
                }
                set
                {
                    this.lonField = value;
                }
            }

            /// <remarks/>
            public string tz_id
            {
                get
                {
                    return this.tz_idField;
                }
                set
                {
                    this.tz_idField = value;
                }
            }

            /// <remarks/>
            public uint localtime_epoch
            {
                get
                {
                    return this.localtime_epochField;
                }
                set
                {
                    this.localtime_epochField = value;
                }
            }

            /// <remarks/>
            public string localtime
            {
                get
                {
                    return this.localtimeField;
                }
                set
                {
                    this.localtimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rootCurrent
        {

            private uint last_updated_epochField;

            private string last_updatedField;

            private decimal temp_cField;

            private decimal temp_fField;

            private byte is_dayField;

            private rootCurrentCondition conditionField;

            private byte wind_mphField;

            private decimal wind_kphField;

            private byte wind_degreeField;

            private string wind_dirField;

            private ushort pressure_mbField;

            private decimal pressure_inField;

            private byte precip_mmField;

            private byte precip_inField;

            private byte humidityField;

            private byte cloudField;

            private byte feelslike_cField;

            private decimal feelslike_fField;

            private decimal windchill_cField;

            private decimal windchill_fField;

            private byte heatindex_cField;

            private decimal heatindex_fField;

            private decimal dewpoint_cField;

            private decimal dewpoint_fField;

            private byte vis_kmField;

            private byte vis_milesField;

            private byte uvField;

            private decimal gust_mphField;

            private decimal gust_kphField;

            /// <remarks/>
            public uint last_updated_epoch
            {
                get
                {
                    return this.last_updated_epochField;
                }
                set
                {
                    this.last_updated_epochField = value;
                }
            }

            /// <remarks/>
            public string last_updated
            {
                get
                {
                    return this.last_updatedField;
                }
                set
                {
                    this.last_updatedField = value;
                }
            }

            /// <remarks/>
            public decimal temp_c
            {
                get
                {
                    return this.temp_cField;
                }
                set
                {
                    this.temp_cField = value;
                }
            }

            /// <remarks/>
            public decimal temp_f
            {
                get
                {
                    return this.temp_fField;
                }
                set
                {
                    this.temp_fField = value;
                }
            }

            /// <remarks/>
            public byte is_day
            {
                get
                {
                    return this.is_dayField;
                }
                set
                {
                    this.is_dayField = value;
                }
            }

            /// <remarks/>
            public rootCurrentCondition condition
            {
                get
                {
                    return this.conditionField;
                }
                set
                {
                    this.conditionField = value;
                }
            }

            /// <remarks/>
            public byte wind_mph
            {
                get
                {
                    return this.wind_mphField;
                }
                set
                {
                    this.wind_mphField = value;
                }
            }

            /// <remarks/>
            public decimal wind_kph
            {
                get
                {
                    return this.wind_kphField;
                }
                set
                {
                    this.wind_kphField = value;
                }
            }

            /// <remarks/>
            public byte wind_degree
            {
                get
                {
                    return this.wind_degreeField;
                }
                set
                {
                    this.wind_degreeField = value;
                }
            }

            /// <remarks/>
            public string wind_dir
            {
                get
                {
                    return this.wind_dirField;
                }
                set
                {
                    this.wind_dirField = value;
                }
            }

            /// <remarks/>
            public ushort pressure_mb
            {
                get
                {
                    return this.pressure_mbField;
                }
                set
                {
                    this.pressure_mbField = value;
                }
            }

            /// <remarks/>
            public decimal pressure_in
            {
                get
                {
                    return this.pressure_inField;
                }
                set
                {
                    this.pressure_inField = value;
                }
            }

            /// <remarks/>
            public byte precip_mm
            {
                get
                {
                    return this.precip_mmField;
                }
                set
                {
                    this.precip_mmField = value;
                }
            }

            /// <remarks/>
            public byte precip_in
            {
                get
                {
                    return this.precip_inField;
                }
                set
                {
                    this.precip_inField = value;
                }
            }

            /// <remarks/>
            public byte humidity
            {
                get
                {
                    return this.humidityField;
                }
                set
                {
                    this.humidityField = value;
                }
            }

            /// <remarks/>
            public byte cloud
            {
                get
                {
                    return this.cloudField;
                }
                set
                {
                    this.cloudField = value;
                }
            }

            /// <remarks/>
            public byte feelslike_c
            {
                get
                {
                    return this.feelslike_cField;
                }
                set
                {
                    this.feelslike_cField = value;
                }
            }

            /// <remarks/>
            public decimal feelslike_f
            {
                get
                {
                    return this.feelslike_fField;
                }
                set
                {
                    this.feelslike_fField = value;
                }
            }

            /// <remarks/>
            public decimal windchill_c
            {
                get
                {
                    return this.windchill_cField;
                }
                set
                {
                    this.windchill_cField = value;
                }
            }

            /// <remarks/>
            public decimal windchill_f
            {
                get
                {
                    return this.windchill_fField;
                }
                set
                {
                    this.windchill_fField = value;
                }
            }

            /// <remarks/>
            public byte heatindex_c
            {
                get
                {
                    return this.heatindex_cField;
                }
                set
                {
                    this.heatindex_cField = value;
                }
            }

            /// <remarks/>
            public decimal heatindex_f
            {
                get
                {
                    return this.heatindex_fField;
                }
                set
                {
                    this.heatindex_fField = value;
                }
            }

            /// <remarks/>
            public decimal dewpoint_c
            {
                get
                {
                    return this.dewpoint_cField;
                }
                set
                {
                    this.dewpoint_cField = value;
                }
            }

            /// <remarks/>
            public decimal dewpoint_f
            {
                get
                {
                    return this.dewpoint_fField;
                }
                set
                {
                    this.dewpoint_fField = value;
                }
            }

            /// <remarks/>
            public byte vis_km
            {
                get
                {
                    return this.vis_kmField;
                }
                set
                {
                    this.vis_kmField = value;
                }
            }

            /// <remarks/>
            public byte vis_miles
            {
                get
                {
                    return this.vis_milesField;
                }
                set
                {
                    this.vis_milesField = value;
                }
            }

            /// <remarks/>
            public byte uv
            {
                get
                {
                    return this.uvField;
                }
                set
                {
                    this.uvField = value;
                }
            }

            /// <remarks/>
            public decimal gust_mph
            {
                get
                {
                    return this.gust_mphField;
                }
                set
                {
                    this.gust_mphField = value;
                }
            }

            /// <remarks/>
            public decimal gust_kph
            {
                get
                {
                    return this.gust_kphField;
                }
                set
                {
                    this.gust_kphField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rootCurrentCondition
        {

            private string textField;

            private string iconField;

            private ushort codeField;

            /// <remarks/>
            public string text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }

            /// <remarks/>
            public string icon
            {
                get
                {
                    return this.iconField;
                }
                set
                {
                    this.iconField = value;
                }
            }

            /// <remarks/>
            public ushort code
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
        }



    }
}
