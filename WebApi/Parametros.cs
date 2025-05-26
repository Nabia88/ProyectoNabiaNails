using DAL;

namespace WebApi
{
    public static class Parametros
    {
        //Escribir la cadena de conexion

#if DEBUG

        public static string CadenaConexion = @"SERVER=MOONFLOWER-88\SQLEXPRESS01; DATABASE=NabiaNails; Integrated Security=True; TrustServerCertificate=True";

#else
        public static string
        CadenaConexion="Server=db18072.databaseasp.net; Database=db18072; User Id=db18072; Password=T!t3_x8Sd5B-; Encrypt=False; MultipleActiveResultSets=True;";

#endif


        public static TipoDB Tipo = TipoDB.SQLServer;

        public static FabricRepository FabricaRepository = new FabricRepository(CadenaConexion, Tipo);
    }
}

