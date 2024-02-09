using System.ComponentModel.DataAnnotations;

namespace Personels.Models
{
    public class Member
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public string Lastname { get; set; }

        public long NationalCode { get; set; }

        public long PhoneNumber { get; set; }


        public DateTime SignUpDate { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public ActivesionType ActivesionType { get; set; }
    }

        public enum Gender
        {
            Male,Female
        }
        public enum ActivesionType
        {
            Silver,Golden,Diamond
        }
    }
