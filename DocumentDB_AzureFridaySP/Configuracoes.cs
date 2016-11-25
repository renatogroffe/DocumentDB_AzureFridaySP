using System.Configuration;

namespace DocumentDB_AzureFridaySP
{
    public static class Configuracoes
    {
        public static string EndpointUri
        {
            get
            {
                return ConfigurationManager.AppSettings["EndpointUri"];
            }
        }

        public static string PrimaryKey
        {
            get
            {
                return ConfigurationManager.AppSettings["PrimaryKey"];
            }
        }

        public static string Database
        {
            get
            {
                return ConfigurationManager.AppSettings["Database"];
            }
        }

        public static string ColecaoCatalogo
        {
            get
            {
                return ConfigurationManager.AppSettings["ColecaoCatalogo"];
            }
        }
    }
}