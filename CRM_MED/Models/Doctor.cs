using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_MED.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(71)]
        public string Patronymic { get; set; }
        [StringLength(150)]
        public string PhoneNumber { get; set; }

        [StringLength(150)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(100)]
        public string Speciality { get; set; }

        [StringLength(15)]
        public string Login { get; set; }

        [StringLength(8)]
        public string Password { get; set; }

        [StringLength(600)]
        public string PhotoPath { get; set; }

        public virtual ICollection<MedicalCard> MedicalCards { get; } = new List<MedicalCard>();

        public virtual ICollection<Reception> Receptions { get; } = new List<Reception>();

    }
}
