namespace TEST_DEFIS_APP.Models
{
    public class Films
    {
        public Guid Id { get; set; }
        public string? Code { get; set; }
        public string? Titre { get; set; }
        public string? Description { get; set; }
        public int Duree { get; set; }
        public bool EstDisponible { get; set; }
        public int CategorieId { get; set; }
        public int AuteurId { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        public bool EstActif { get; set; }
        public string?  ModifierPar { get; set; }
        public string? UserId { get; set; }
        public Auteur Auteur { get; set; }
    }
}
