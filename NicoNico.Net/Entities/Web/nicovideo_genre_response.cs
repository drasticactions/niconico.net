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
    public partial class nicovideo_genre_response
    {

        private nicovideo_genre_responseGroups[] groupsField;

        private string statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("groups")]
        public nicovideo_genre_responseGroups[] groups
        {
            get
            {
                return this.groupsField;
            }
            set
            {
                this.groupsField = value;
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
    public partial class nicovideo_genre_responseGroups
    {

        private string groupField;

        private string nameField;

        private string[] keyField;

        /// <remarks/>
        public string group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }

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
        [System.Xml.Serialization.XmlElementAttribute("key")]
        public string[] key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
    }

    public partial class nicovideo_genre_response
    {

        private nicovideo_genre_responseGenre[] genreField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("genre")]
        public nicovideo_genre_responseGenre[] genre
        {
            get
            {
                return this.genreField;
            }
            set
            {
                this.genreField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class nicovideo_genre_responseGenre
    {

        private string keyField;

        private string tagField;

        /// <remarks/>
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        public string tag
        {
            get
            {
                return this.tagField;
            }
            set
            {
                this.tagField = value;
            }
        }
    }



}
