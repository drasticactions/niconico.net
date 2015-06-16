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
    public partial class packet
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("chat", typeof(packetChat))]
        [System.Xml.Serialization.XmlElementAttribute("leaf", typeof(packetLeaf))]
        [System.Xml.Serialization.XmlElementAttribute("thread", typeof(packetThread))]
        [System.Xml.Serialization.XmlElementAttribute("view_counter", typeof(packetView_counter))]
        public object[] Items
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class packetChat
    {

        private uint threadField;

        private ushort noField;

        private uint vposField;

        private uint dateField;

        private string mailField;

        private string user_idField;

        private byte premiumField;

        private bool premiumFieldSpecified;

        private byte anonymityField;

        private bool anonymityFieldSpecified;

        private byte leafField;

        private bool leafFieldSpecified;

        private short scoreField;

        private bool scoreFieldSpecified;

        private byte deletedField;

        private bool deletedFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint thread
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort no
        {
            get
            {
                return this.noField;
            }
            set
            {
                this.noField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint vpos
        {
            get
            {
                return this.vposField;
            }
            set
            {
                this.vposField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mail
        {
            get
            {
                return this.mailField;
            }
            set
            {
                this.mailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string user_id
        {
            get
            {
                return this.user_idField;
            }
            set
            {
                this.user_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte premium
        {
            get
            {
                return this.premiumField;
            }
            set
            {
                this.premiumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool premiumSpecified
        {
            get
            {
                return this.premiumFieldSpecified;
            }
            set
            {
                this.premiumFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte anonymity
        {
            get
            {
                return this.anonymityField;
            }
            set
            {
                this.anonymityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool anonymitySpecified
        {
            get
            {
                return this.anonymityFieldSpecified;
            }
            set
            {
                this.anonymityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte leaf
        {
            get
            {
                return this.leafField;
            }
            set
            {
                this.leafField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool leafSpecified
        {
            get
            {
                return this.leafFieldSpecified;
            }
            set
            {
                this.leafFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public short score
        {
            get
            {
                return this.scoreField;
            }
            set
            {
                this.scoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool scoreSpecified
        {
            get
            {
                return this.scoreFieldSpecified;
            }
            set
            {
                this.scoreFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deletedSpecified
        {
            get
            {
                return this.deletedFieldSpecified;
            }
            set
            {
                this.deletedFieldSpecified = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class packetLeaf
    {

        private uint threadField;

        private ushort countField;

        private byte leafField;

        private bool leafFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint thread
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort count
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte leaf
        {
            get
            {
                return this.leafField;
            }
            set
            {
                this.leafField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool leafSpecified
        {
            get
            {
                return this.leafFieldSpecified;
            }
            set
            {
                this.leafFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class packetThread
    {

        private byte resultcodeField;

        private uint threadField;

        private ushort last_resField;

        private bool last_resFieldSpecified;

        private string ticketField;

        private byte revisionField;

        private uint server_timeField;

        private byte forkField;

        private bool forkFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte resultcode
        {
            get
            {
                return this.resultcodeField;
            }
            set
            {
                this.resultcodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint thread
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort last_res
        {
            get
            {
                return this.last_resField;
            }
            set
            {
                this.last_resField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool last_resSpecified
        {
            get
            {
                return this.last_resFieldSpecified;
            }
            set
            {
                this.last_resFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ticket
        {
            get
            {
                return this.ticketField;
            }
            set
            {
                this.ticketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte revision
        {
            get
            {
                return this.revisionField;
            }
            set
            {
                this.revisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint server_time
        {
            get
            {
                return this.server_timeField;
            }
            set
            {
                this.server_timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fork
        {
            get
            {
                return this.forkField;
            }
            set
            {
                this.forkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool forkSpecified
        {
            get
            {
                return this.forkFieldSpecified;
            }
            set
            {
                this.forkFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class packetView_counter
    {

        private uint videoField;

        private string idField;

        private ushort mylistField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint video
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort mylist
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
    }


}
