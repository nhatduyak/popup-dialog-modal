using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName ="nvarchar(12)")]
        public string AccountNumber { get; set; }
        [Column(TypeName ="nvarchar(100)")]

        public string BeneficiaryName { get; set; }
        [Column(TypeName ="nvarchar(100)")]

        public string BankName { get; set; }
        [Column(TypeName ="nvarchar(11)")]

        public string   SWIFTCode { get; set; }

        public double Amount { get; set; }
    }
}