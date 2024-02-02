namespace TEST_DEFIS_APP.Models
{
    public class Auteur
    {
        public Guid id { get; set; }
        public string? code { get; set; }
        public string? libelle { get; set; }
        public string? description { get; set; }
        public DateTime date_creation { get; set; }
        public DateTime? date_modification { get; set; }
        public bool est_actif { get; set; }
        public string? modifier_par { get; set; }
        public string? userid { get; set; }
        public List<Films>? FilmsAuteurs { get; set; }
    }
}
