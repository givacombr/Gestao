namespace DAL
{
    public static class Conexao
    {
        public static string StringDeConexao 
        {
            get
            {
                return @"User ID=SA;Initial Catalog=Gestao;Data Source=.\SQLEXPRESS2019;Password=Senailab02";
                /*return @"User ID=SA;Initial Catalog=Gestao;Data Source=.\SQLEXPRESS;Password=admin123";*/
            }
        }
    }
}
