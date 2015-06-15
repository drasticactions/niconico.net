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
    public partial class nicovideo_user_response
    {

        private string session_keyField;

        private string expireField;

        private uint user_idField;

        private string statusField;

        /// <remarks/>
        public string session_key
        {
            get
            {
                return this.session_keyField;
            }
            set
            {
                this.session_keyField = value;
            }
        }

        /// <remarks/>
        public string expire
        {
            get
            {
                return this.expireField;
            }
            set
            {
                this.expireField = value;
            }
        }

        /// <remarks/>
        public uint user_id
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

    public partial class nicovideo_user_response
    {

        private nicovideo_user_responseUser userField;

        private string sessionField;

        private string status1Field;

        /// <remarks/>
        public nicovideo_user_responseUser user
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }

        /// <remarks/>
        public string session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }

        public string status1
        {
            get
            {
                return this.status1Field;
            }
            set
            {
                this.status1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class nicovideo_user_responseUser
    {

        private uint idField;

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
    }

    public partial class nicovideo_user_response
    {
        private object additionalsField;

        private nicovideo_user_responseVita_option vita_optionField;

        /// <remarks/>
        public object additionals
        {
            get
            {
                return this.additionalsField;
            }
            set
            {
                this.additionalsField = value;
            }
        }

        /// <remarks/>
        public nicovideo_user_responseVita_option vita_option
        {
            get
            {
                return this.vita_optionField;
            }
            set
            {
                this.vita_optionField = value;
            }
        }
    }

    public partial class nicovideo_user_responseUser
    {

        private byte mobile_mailField;

        private string nicknameField;

        private string prefectureField;

        private System.DateTime birthdayField;

        private string sexField;

        private string countryField;

        private string languageField;

        private System.DateTime create_timeField;

        private System.DateTime update_timeField;

        private string thumbnail_urlField;

        /// <remarks/>
        public byte mobile_mail
        {
            get
            {
                return this.mobile_mailField;
            }
            set
            {
                this.mobile_mailField = value;
            }
        }

        /// <remarks/>
        public string nickname
        {
            get
            {
                return this.nicknameField;
            }
            set
            {
                this.nicknameField = value;
            }
        }

        /// <remarks/>
        public string prefecture
        {
            get
            {
                return this.prefectureField;
            }
            set
            {
                this.prefectureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime birthday
        {
            get
            {
                return this.birthdayField;
            }
            set
            {
                this.birthdayField = value;
            }
        }

        /// <remarks/>
        public string sex
        {
            get
            {
                return this.sexField;
            }
            set
            {
                this.sexField = value;
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
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class nicovideo_user_responseVita_option
    {

        private byte user_secretField;

        private byte simple_register_profileField;

        /// <remarks/>
        public byte user_secret
        {
            get
            {
                return this.user_secretField;
            }
            set
            {
                this.user_secretField = value;
            }
        }

        /// <remarks/>
        public byte simple_register_profile
        {
            get
            {
                return this.simple_register_profileField;
            }
            set
            {
                this.simple_register_profileField = value;
            }
        }
    }

    public partial class nicovideo_user_response
    {

        private byte premiumField;

        private uint expire_timeField;

        private byte purchasableField;


        /// <remarks/>
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
        public uint expire_time
        {
            get
            {
                return this.expire_timeField;
            }
            set
            {
                this.expire_timeField = value;
            }
        }

        /// <remarks/>
        public byte purchasable
        {
            get
            {
                return this.purchasableField;
            }
            set
            {
                this.purchasableField = value;
            }
        }
    }

    public partial class nicovideo_user_response
    {

        private nicovideo_user_responseError errorField;


        /// <remarks/>
        public nicovideo_user_responseError error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class nicovideo_user_responseError
    {

        private string codeField;

        private string descriptionField;

        /// <remarks/>
        public string code
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

        /// <remarks/>
        public string description
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
    }



}
