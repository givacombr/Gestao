namespace Models
{
    public class GrupoUsuario
    {
        public int IGrupoUsuario { get; set; }
        public string? NomeGrupo { get; set; }
        public List<Permissao>? Permissoes { get; set; }
    }
}
