namespace TEST_DEFIS_APP.Models
{
    public class UserModel
    {
        public Guid id { get; set; }
        public string? nom { get; set; }
        public string? prenoms { get; set; }
        public string? adresse_geographique { get; set; }
        public string? telephone { get; set; }
        public DateTime date_creation { get; set; }
        public bool est_actif { get; set; }
        public string? modifier_par { get; set; }
        public string? userid { get; set; }
        //public List<FilmsModels> username { get; set;}
    }
}
