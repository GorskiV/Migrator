using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Smo;
using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.Windows.Forms;
using System.Threading;


namespace Migrator
{
    class MigratorModel
    {
        public bool Mysql(string ConnectionString)
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(ConnectionString);
                con.Open();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public DataTable MySqlTables(string ConnectionString)
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(ConnectionString);
                con.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string upit = "show full tables where Table_Type != 'VIEW';";
                MyDA.SelectCommand = new MySqlCommand(upit, con);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                return table;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public bool SqlServer(string ConnectionString)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public DataTable SqlServerTablice(string ConnectionString)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                string upit = "SELECT TABLE_NAME as Tables FROM information_schema.tables;";
                SqlDataAdapter SqlDA = new SqlDataAdapter(upit, con);
                DataTable dt = new DataTable();
                SqlDA.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public bool PostgreSQL(string ConnectionString)
        {
            NpgsqlConnection con = new NpgsqlConnection(ConnectionString);
            try
            {
                con.Open();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        public DataTable PostgreSQLTablice(string ConnectionString)
        {
            NpgsqlConnection con = null;
            try
            {
                con = new NpgsqlConnection(ConnectionString);
                con.Open();
                string upit = "select table_name as Tables from information_schema.tables WHERE table_type = 'BASE TABLE' AND table_schema NOT IN ('pg_catalog', 'information_schema');";
                NpgsqlDataAdapter PostgreDA = new NpgsqlDataAdapter(upit, con);
                DataTable dt = new DataTable();
                PostgreDA.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public DataTable MySqlViews(string ConnectionString)
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(ConnectionString);
                con.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string upit = "select TABLE_NAME as Views from information_schema.tables where TABLE_TYPE like 'VIEW';";
                MyDA.SelectCommand = new MySqlCommand(upit, con);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                return table;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public DataTable SqlServerPogledi(string ConnectionString)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                string upit = "SELECT TABLE_NAME as Views FROM INFORMATION_SCHEMA.Views;";
                SqlDataAdapter SqlDA = new SqlDataAdapter(upit, con);
                DataTable dt = new DataTable();
                SqlDA.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public DataTable PostgreSQLPogledi(string ConnectionString)
        {
            NpgsqlConnection con = null;
            try
            {
                con = new NpgsqlConnection(ConnectionString);
                con.Open();
                string upit = "select table_name as Views from INFORMATION_SCHEMA.views WHERE table_schema = ANY (current_schemas(false));";
                NpgsqlDataAdapter PostgreDA = new NpgsqlDataAdapter(upit, con);
                DataTable dt = new DataTable();
                PostgreDA.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public DataTable MySqlProcedures(string ConnectionString)
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(ConnectionString);
                con.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string upit = "SELECT SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES;";
                MyDA.SelectCommand = new MySqlCommand(upit, con);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                return table;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public DataTable SqlServerProcedure(string ConnectionString)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                string upit = "select ROUTINE_NAME as Procedures from information_schema.routines";
                SqlDataAdapter SqlDA = new SqlDataAdapter(upit, con);
                DataTable dt = new DataTable();
                SqlDA.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public DataTable PostgreSQLProcedure(string ConnectionString)
        {
            NpgsqlConnection con = null;
            try
            {
                con = new NpgsqlConnection(ConnectionString);
                con.Open();
                string upit = "SELECT proname as Functions FROM pg_catalog.pg_namespace n JOIN pg_catalog.pg_proc p ON pronamespace=n.oid WHERE nspname='public';";
                NpgsqlDataAdapter PostgreDA = new NpgsqlDataAdapter(upit, con);
                DataTable dt = new DataTable();
                PostgreDA.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public DataTable MySqlTriggers(string ConnectionString)
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(ConnectionString);
                con.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string upit = "select trigger_name as Triggers from information_schema.triggers;";
                MyDA.SelectCommand = new MySqlCommand(upit, con);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                return table;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public DataTable SqlServerOkidaci(string ConnectionString)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                string upit = "Select [tgr].[name] as Triggers from sysobjects tgr join sysobjects tbl on tgr.parent_obj = tbl.id WHERE tgr.xtype = 'TR';";
                SqlDataAdapter SqlDA = new SqlDataAdapter(upit, con);
                DataTable dt = new DataTable();
                SqlDA.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public DataTable PostgreSQLOkidaci(string ConnectionString)
        {
            NpgsqlConnection con = null;
            try
            {
                con = new NpgsqlConnection(ConnectionString);
                con.Open();
                string upit = "select tgname as Triggers from pg_trigger where tgtype=7;";
                NpgsqlDataAdapter PostgreDA = new NpgsqlDataAdapter(upit, con);
                DataTable dt = new DataTable();
                PostgreDA.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        //MySql backup !!!!!!
        public void MySQLExport(bool sve, List<string> tablice, bool pogledi, bool procedure, bool okidaci, string ConnectionString, string pohrana)
        {

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = con;
                        con.Open();
                        if (sve == true)
                        {
                            mb.ExportInfo.AddCreateDatabase = true; //mje
                            mb.ExportInfo.ExportTableStructure = true;
                            mb.ExportInfo.ExportRows = true;
                            mb.ExportInfo.ExportEvents = true;
                            mb.ExportInfo.ExportFunctions = true;
                            mb.ExportInfo.ExportProcedures = true;
                            mb.ExportInfo.ExportTriggers = true;
                            mb.ExportInfo.ExportViews = true;
                            mb.ExportToFile(pohrana);
                        }
                        else if (tablice.Count > 0)
                        {
                            mb.ExportInfo.AddCreateDatabase = false; //mje
                            mb.ExportInfo.ExportTableStructure = true;
                            mb.ExportInfo.TablesToBeExportedList = tablice;
                            mb.ExportInfo.ExportRows = true;
                            mb.ExportInfo.ExportEvents = false;
                            mb.ExportInfo.ExportFunctions = false;
                            mb.ExportInfo.ExportProcedures = false;
                            mb.ExportInfo.ExportTriggers = false;
                            mb.ExportInfo.ExportViews = false;
                            mb.ExportToFile(pohrana);
                        }
                        else if (okidaci == true)
                        {
                            mb.ExportInfo.AddCreateDatabase = false;
                            mb.ExportInfo.ExportTableStructure = false;
                            mb.ExportInfo.ExportRows = false;
                            mb.ExportInfo.ExportEvents = false;
                            mb.ExportInfo.ExportFunctions = false;
                            mb.ExportInfo.ExportProcedures = false;
                            mb.ExportInfo.ExportTriggers = true;
                            mb.ExportInfo.ExportViews = false;
                            mb.ExportToFile(pohrana);
                        }
                        else if (procedure == true)
                        {
                            mb.ExportInfo.AddCreateDatabase = false;
                            mb.ExportInfo.ExportTableStructure = false;
                            mb.ExportInfo.ExportRows = false;
                            mb.ExportInfo.ExportEvents = false;
                            mb.ExportInfo.ExportFunctions = false;
                            mb.ExportInfo.ExportProcedures = true;
                            mb.ExportInfo.ExportTriggers = false;
                            mb.ExportInfo.ExportViews = false;
                            mb.ExportToFile(pohrana);
                        }
                        else if (pogledi == true)
                        {
                            mb.ExportInfo.AddCreateDatabase = false;
                            mb.ExportInfo.ExportTableStructure = false;
                            mb.ExportInfo.ExportRows = false;
                            mb.ExportInfo.ExportEvents = false;
                            mb.ExportInfo.ExportFunctions = false;
                            mb.ExportInfo.ExportProcedures = false;
                            mb.ExportInfo.ExportTriggers = false;
                            mb.ExportInfo.ExportViews = true;
                            mb.ExportToFile(pohrana);
                            string zamjena = File.ReadAllText(pohrana);
                            zamjena = zamjena.Replace("DROP", "#DROP");
                            File.WriteAllText(pohrana, zamjena);
                        }
                    }
                }
                con.Close();
            }
        }

        public void MySqlImport(bool sve, List<string> tablice, bool pogledi, bool procedure, bool okidaci, string ConnectionString, string pohrana)
        {

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = con;
                        con.Open();
                        if (sve == true)
                        {
                            mb.ImportFromFile(pohrana);
                        }
                        else if (tablice != null)
                        {
                            mb.ImportFromFile(pohrana);
                        }
                        else if (pogledi == true)
                        {
                            mb.ImportFromFile(pohrana);
                        }
                        else if (procedure == true)
                        {
                            mb.ImportFromFile(pohrana);
                        }
                        else if (okidaci == true)
                        {
                            mb.ImportFromFile(pohrana);
                        }
                    }
                }
                con.Close();
            }
        }

        // POSTGRE BACKUP ! ! ! ! !
        /// <summary>
        /// Metoda koja provjerva dali je instaliran pg_dump i pg_restore na računalu radi provedbe backupa
        /// </summary>
        StringBuilder sbPG_dumpPath = new StringBuilder();
        string strInstallLocation = string.Empty;
        String strPG_dumpPath = String.Empty;
        public static Thread dretva;

        public string verifyPostgreInstalation()
        {
            try
            {
                if (sbPG_dumpPath.Length == 0)
                {
                    bool bPostgresService = false;
                    ServiceController[] services = ServiceController.GetServices();
                    // try to find service name
                    foreach (ServiceController service in services)
                    {
                        if (service.ServiceName.Contains("postgre") == true)
                        {
                            bPostgresService = true;
                            break;
                        }
                    }
                    if (bPostgresService == true)
                    {
                        PG_DumpExePath();
                        if (sbPG_dumpPath.Length != 0)
                        {
                            return strInstallLocation;
                        }   
                        return null;

                    }
                    else
                    {
                        MessageBox.Show("Your System is NOT INSATALLED with Postgres", "Warning");
                        return null;
                    }
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void PG_DumpExePath()
        {
            try
            {
                // Do not change lines / spaces b/w words.
                if (sbPG_dumpPath.Length == 0)
                {
                    //string strPG_dumpPath = string.Empty;
                    if (strPG_dumpPath == string.Empty)
                    {
                        strPG_dumpPath = LookForFile("pg_dump.exe");
                        if (strPG_dumpPath == string.Empty)
                        {
                            MessageBox.Show("Postgres is not installed");
                        }
                    }

                    int a = strPG_dumpPath.IndexOf(":\\", 0);
                    a = a + 2;
                    string strSub = strPG_dumpPath.Substring(0, (a - 2));
                    strPG_dumpPath = strPG_dumpPath.Substring(a, (strPG_dumpPath.Length - a));

                    StringBuilder sbSB1 = new StringBuilder(strPG_dumpPath);
                    sbSB1.Replace("\\", "\r\n\r\ncd ");

                    StringBuilder sbSB2 = new StringBuilder("cd /D ");
                    sbSB2.Append(strSub);
                    sbSB2.Append(":\\");

                    sbSB1 = sbSB2.Append(sbSB1);
                    sbSB1 = sbSB1.Remove((sbSB1.Length - 3), 3);
                    sbPG_dumpPath = sbSB1;
                    strPG_dumpPath = sbSB1.ToString();
                }
            }
            catch (Exception ex)
            { }
        }

        private string LookForFile(string strFileName)
        {
            string strPG_dumpPath = string.Empty;
            try
            {
                DriveInfo[] drives = DriveInfo.GetDrives();

                foreach (DriveInfo drive in drives)
                {
                    strPG_dumpPath = performFileSearchTask(drive.Name, strFileName);
                    if (strPG_dumpPath.Length != 0)
                        break;
                }

            }
            catch (Exception ex)
            { }
            return strPG_dumpPath;
        }

        private string performFileSearchTask(string dirName, string strfileName)
        {
            try
            {
                if (strPG_dumpPath.Length == 0)
                {
                    try
                    {

                        foreach (string ddir in Directory.GetDirectories(dirName))
                        {
                            System.Security.Permissions.FileIOPermission ReadPermission =
                                new System.Security.Permissions.FileIOPermission(System.Security.Permissions.FileIOPermissionAccess.Write, ddir);
                            if (System.Security.SecurityManager.IsGranted(ReadPermission))
                            {
                                try
                                {
                                    foreach (string dfile in Directory.GetFiles(ddir, strfileName))
                                    {
                                        strPG_dumpPath = ddir + "\\";
                                        if (strPG_dumpPath.Length > 0)
                                        {
                                            strInstallLocation = strPG_dumpPath;
                                            break;
                                        }
                                    }
                                    if (strPG_dumpPath.Length == 0)
                                        performFileSearchTask(ddir, strfileName);
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (strPG_dumpPath != string.Empty)
                                break;
                        }
                    }
                    catch (Exception ex)
                    { }

                }

            }
            catch (Exception ex)
            { }
            return strPG_dumpPath;
        }

        //SQL SERVER BACKUP
        public void PostgreSQLBackupImport(string commandType, string commandSentence)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.FileName = frmGlavna.postgreInstalation + commandType + ".exe ";
            info.Arguments = commandSentence;
            Console.Write(info.FileName + info.Arguments);
            info.CreateNoWindow = false;
            info.UseShellExecute = true;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = info;
            proc.Start();
            proc.WaitForExit();
        }

        public void SQLServerExportStrukturaBaze(string ConnectionString, string sourceDbPath, string destinationScriptPath)
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            ServerConnection serverConn = new ServerConnection(sqlConn);
            Server server = new Server(serverConn);
            Database database = server.Databases[sourceDbPath];
            Transfer transfer = new Transfer(database);
            ScriptingOptions options = new ScriptingOptions();
            options.AppendToFile = false;      // Overwrite file
            options.ClusteredIndexes = false;
            options.SetTargetDatabaseEngineType(DatabaseEngineType.SqlAzureDatabase);
            options.Indexes = true;
            options.DriAll = true;
            options.Triggers = true;
            options.Bindings = true;
            options.Default = true;
            options.IncludeDatabaseContext = false;
            options.IncludeHeaders = true;
            options.FullTextIndexes = true;
            options.SchemaQualify = true;
            options.SchemaQualifyForeignKeysReferences = true;
            options.ScriptSchema = true; 
            options.ScriptData = false;
            options.ScriptDrops = false;
            options.FileName = destinationScriptPath;
            transfer.Options = options;
            transfer.CopyAllFullTextCatalogs = true;
            transfer.CopyAllFullTextStopLists = true;
            transfer.CopyAllTables = true;
            transfer.CopyData = true;
            transfer.ScriptTransfer();
        }

        public void SQLServerExportPodaci(string ConnectionString, string sourceDbPath, string destinationScriptPath)
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            ServerConnection serverConn = new ServerConnection(sqlConn);
            Server server = new Server(serverConn);
            Database database = server.Databases[sourceDbPath];
            var output = new StringBuilder();

            foreach (Table table in database.Tables)
            {
                var scripter = new Scripter(server) { Options = { ScriptSchema = false, ContinueScriptingOnError = true, DriAllConstraints = false, DriPrimaryKey = false, DriUniqueKeys = false, DriForeignKeys = false, SchemaQualify = true, SchemaQualifyForeignKeysReferences = false, ScriptData = true, TargetDatabaseEngineType = DatabaseEngineType.SqlAzureDatabase } };
                var script = scripter.EnumScript(new SqlSmoObject[] { table });
                foreach (var line in script)
                    output.AppendLine(line);
            }
            File.WriteAllText(destinationScriptPath, output.ToString());
        }

        public void SqlServerImport(string ConnectionString, string pohrana)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            Regex regex = new Regex(@"\r{0,1}\nGO\r{0,1}\n");
            //FileInfo file = new FileInfo(@"D:\qwe\SQLServer.sql");
            FileInfo file = new FileInfo(pohrana);
            string script = file.OpenText().ReadToEnd();
            string[] commands = regex.Split(script);
            con.Open();
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] != string.Empty)
                {
                    using (SqlCommand command = new SqlCommand(commands[i], con))
                    {
                        command.ExecuteNonQuery();
                        command.Dispose();
                    }
                }
            }
            con.Close();
        }
    }
}
