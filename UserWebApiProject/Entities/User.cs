using Newtonsoft.Json;

namespace UserWebApiProject.Entities
{
    //User modeli, alanları veritabanındaki colonları temsil eder.
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }


    }
}
