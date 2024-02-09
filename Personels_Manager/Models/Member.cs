namespace Personels_Manager.Models
{
    public class Member
    {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime RegistrationDate { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string NationalCode { get; set; }
            public string PhoneNumber { get; set; }
            public MembershipType MembershipType { get; set; }
            public Gender Gender { get; set; }
        }

        public enum MembershipType
        {
            Gold,
            Silver,
            Bronze
        }

        public enum Gender
        {
            Male,
            Female
        }

    }

