using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicoNico.Net.Entities.Web
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class nicovideo_video_response
    {

        private byte countField;

        private nicovideo_video_responseVideo_info[] video_infoField;

        private string statusField;

        /// <remarks/>
        public byte count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("video_info")]
        public nicovideo_video_responseVideo_info[] video_info
        {
            get
            {
                return this.video_infoField;
            }
            set
            {
                this.video_infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class nicovideo_video_responseVideo_info
    {

        private nicovideo_video_responseVideo_infoVideo videoField;

        private nicovideo_video_responseVideo_infoMylist mylistField;

        private nicovideo_video_responseVideo_infoThread threadField;

        /// <remarks/>
        public nicovideo_video_responseVideo_infoVideo video
        {
            get
            {
                return this.videoField;
            }
            set
            {
                this.videoField = value;
            }
        }

        public nicovideo_video_responseVideo_infoMylist mylist
        {
            get
            {
                return this.mylistField;
            }
            set
            {
                this.mylistField = value;
            }
        }

        /// <remarks/>
        public nicovideo_video_responseVideo_infoThread thread
        {
            get
            {
                return this.threadField;
            }
            set
            {
                this.threadField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class nicovideo_video_responseVideo_infoVideo
    {

        private string idField;

        private byte deletedField;

        private string titleField;

        private ushort length_in_secondsField;

        private string thumbnail_urlField;

        private System.DateTime upload_timeField;

        private System.DateTime first_retrieveField;

        private uint view_counterField;

        private ushort mylist_counterField;

        private byte option_flag_communityField;

        private byte option_flag_nicowariField;

        private byte option_flag_middle_thumbnailField;

        private ushort widthField;

        private ushort heightField;

        private string vita_playableField;

        private byte ppv_videoField;

        private string provider_typeField;

        private nicovideo_video_responseVideo_infoVideoOptions optionsField;

        /// <remarks/>
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public byte deleted
        {
            get
            {
                return this.deletedField;
            }
            set
            {
                this.deletedField = value;
            }
        }

        /// <remarks/>
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public ushort length_in_seconds
        {
            get
            {
                return this.length_in_secondsField;
            }
            set
            {
                this.length_in_secondsField = value;
            }
        }

        /// <remarks/>
        public string thumbnail_url
        {
            get
            {
                return this.thumbnail_urlField;
            }
            set
            {
                this.thumbnail_urlField = value;
            }
        }

        /// <remarks/>
        public System.DateTime upload_time
        {
            get
            {
                return this.upload_timeField;
            }
            set
            {
                this.upload_timeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime first_retrieve
        {
            get
            {
                return this.first_retrieveField;
            }
            set
            {
                this.first_retrieveField = value;
            }
        }

        /// <remarks/>
        public uint view_counter
        {
            get
            {
                return this.view_counterField;
            }
            set
            {
                this.view_counterField = value;
            }
        }

        /// <remarks/>
        public ushort mylist_counter
        {
            get
            {
                return this.mylist_counterField;
            }
            set
            {
                this.mylist_counterField = value;
            }
        }

        /// <remarks/>
        public byte option_flag_community
        {
            get
            {
                return this.option_flag_communityField;
            }
            set
            {
                this.option_flag_communityField = value;
            }
        }

        /// <remarks/>
        public byte option_flag_nicowari
        {
            get
            {
                return this.option_flag_nicowariField;
            }
            set
            {
                this.option_flag_nicowariField = value;
            }
        }

        /// <remarks/>
        public byte option_flag_middle_thumbnail
        {
            get
            {
                return this.option_flag_middle_thumbnailField;
            }
            set
            {
                this.option_flag_middle_thumbnailField = value;
            }
        }

        /// <remarks/>
        public ushort width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public ushort height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public string vita_playable
        {
            get
            {
                return this.vita_playableField;
            }
            set
            {
                this.vita_playableField = value;
            }
        }

        /// <remarks/>
        public byte ppv_video
        {
            get
            {
                return this.ppv_videoField;
            }
            set
            {
                this.ppv_videoField = value;
            }
        }

        /// <remarks/>
        public string provider_type
        {
            get
            {
                return this.provider_typeField;
            }
            set
            {
                this.provider_typeField = value;
            }
        }

        /// <remarks/>
        public nicovideo_video_responseVideo_infoVideoOptions options
        {
            get
            {
                return this.optionsField;
            }
            set
            {
                this.optionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class nicovideo_video_responseVideo_infoVideoOptions
    {

        private byte mobileField;

        private byte sunField;

        private byte large_thumbnailField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sun
        {
            get
            {
                return this.sunField;
            }
            set
            {
                this.sunField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte large_thumbnail
        {
            get
            {
                return this.large_thumbnailField;
            }
            set
            {
                this.large_thumbnailField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class nicovideo_video_responseVideo_infoThread
    {

        private uint idField;

        private ushort num_resField;

        private string summaryField;

        /// <remarks/>
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public ushort num_res
        {
            get
            {
                return this.num_resField;
            }
            set
            {
                this.num_resField = value;
            }
        }

        /// <remarks/>
        public string summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }
    }

    public partial class nicovideo_video_response
    {

        private byte total_countField;

        /// <remarks/>
        public byte total_count
        {
            get
            {
                return this.total_countField;
            }
            set
            {
                this.total_countField = value;
            }
        }
    }


    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class nicovideo_video_responseVideo_infoMylist
    {

        private object descriptionField;

        private System.DateTime update_timeField;

        private System.DateTime create_timeField;

        /// <remarks/>
        public object description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public System.DateTime update_time
        {
            get
            {
                return this.update_timeField;
            }
            set
            {
                this.update_timeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime create_time
        {
            get
            {
                return this.create_timeField;
            }
            set
            {
                this.create_timeField = value;
            }
        }
    }


}
