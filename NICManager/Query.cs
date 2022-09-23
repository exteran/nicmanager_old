using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICManager
{
    public static class Query
    {
        /* 
         * DATABASE CONFIGURATION SETTINGS
         * These settings allow you to set the database server, database name, and the configuration user information.
         * By default, the configUser is called on the first start of the program so that an administrator can create 
         * a superuser account and use the administrative tools in NICManager. Once the installation and setup has been
         * complete, this user will be deleted from the database and only the superuser (or another administrator) will
         * be able to access the administrative functions.
         */
        public static string dbServer =         "localhost";
        public static string dbDatabase =       "nicdb";
        public static string dbUser =           "configUser";
        public static string dbPassword =       "configPassword1";

        public static string configConnect =    "server=" + dbServer + 
                                                ";database=" + dbDatabase + 
                                                ";uid=" + dbUser +
                                                ";pwd=" + dbPassword +";";

        /*
         * DATABASE PRODUCTION SETTINGS
         * These queries are designed for databases in production mode that have completed the configuration process.
         */



        /* 
         * DATABASE CONNECTION OPERATOR QUERIES
         * These queries are used by operators to select and manipulate records.
         */



        /*
         * DATABASE CONNECTION ADMINISTRATOR QUERIES
         * These queries are used by administrators to assert full control over the model.
         */
    }
}
