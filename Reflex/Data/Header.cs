using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflex.Data
{
    public class Header
    {
        public string Template { get; set; }

        //data start here
        /// <summary>
        /// Length: 2
        /// Mandatory
        /// Left with space
        /// </summary>
        public RecordTypes RecordType { get; set; }

        /// <summary>
        /// Length: 8
        /// Mandatory
        /// Left with space
        /// </summary>
        public string EPaymentId { get; set; }

        /// <summary>
        /// CAMS Corporate ID provided by RHB
        /// Length: 6
        /// Mandatory
        /// Left with space
        /// </summary>
        private string corporateId;

        public string CorporateID
        {
            get { return corporateId; }
            set { corporateId = value.Length>6?value.Substring(0,6):value; }
        }


        /// <summary>
        /// CAMS Corporate ID provided by RHB
        /// Length: 40
        /// Mandatory
        /// Left with space
        /// </summary>
        private string corporateName;

        public string CorporateName
        {
            get { return corporateName; }
            set { corporateName = value.Length > 8 ? value.Substring(0, 8) : value; }
        }


        /// <summary>
        /// Account No Only RHB
        /// Length: 14
        /// Mandatory
        /// Right with space
        /// </summary>
        public string DebitingAccountNumber { get; set; }

        /// <summary>
        /// DDMMYYYY
        /// Length: 8
        /// Mandatory
        /// Left with space
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Corporate Batch No
        /// Length: 10
        /// Mandatory
        /// Left with space
        /// </summary>
        public int FileBatchNo { get; set; }

        /// <summary>
        /// CAMS Corporate ID provided by RHB
        /// Length: 12,2
        /// Mandatory
        /// Right with 0
        /// </summary>
        public float TotalDebitingAmount { get; set; }

        /// <summary>
        /// Contact Number
        /// Length: 20
        /// Mandatory
        /// Left with space
        /// </summary>
        public string BussinessRegNo { get; set; }

        /// <summary>
        /// Mailing address 1
        /// Length: 35
        /// Mandatory
        /// Left with space
        /// </summary>
        public string MailingAddress1 { get; set; }

        /// <summary>
        /// Mailing address 2
        /// Length: 35
        /// Mandatory
        /// Left with space
        /// </summary>
        public string MailingAddress2 { get; set; }

        public string ContactNo { get; set; }


        public Header()
        {
            RecordType = RecordTypes.MessageHeader;
            EPaymentId = "ePayment";
            Template = "{0,-2:D2}{1,-8}{2,-6}{3,-40}{4,14}{5}{6,-10}{7,12}{8,-15}{9,-20}{10,-35}{11,-35}";
        }

        public override string ToString()
        {
            //return PaymentDate.ToString();
            return string.Format(Template,
                (int)RecordType,
                EPaymentId,
                CorporateID,
                CorporateName,
                DebitingAccountNumber,
                PaymentDate.ToString("ddMMyyyy"),
                FileBatchNo,
                TotalDebitingAmount*100,
                BussinessRegNo,
                MailingAddress1,
                MailingAddress2,
                ContactNo
            );
        }
    }
}
