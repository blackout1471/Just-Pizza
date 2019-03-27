using System.Data.Sql;
using System.Data.SqlClient;
using System;
using System.Data;

namespace JustPizza.sql
{
    public abstract class DataConnection
    {
        #region Properties
        protected string ConnectionString
        {
            get
            {
                return this.connectionString;
            }
            set
            {
                this.connectionString = value;
            }
        }

        #endregion

        private string connectionString = null;
        private SqlConnection con = null;


        /// <summary>
        /// Checks if the connection string is not empty
        /// </summary>
        /// <returns></returns>
        private bool IsConnectionString()
        {
            if (this.connectionString == null || this.connectionString == "")
                return false;

            return true;
        }

        /// <summary>
        /// Open connection to database
        /// </summary>
        private void Open()
        {
            if (!this.IsConnectionString())
                throw new Exception("The connectionString was not valid");

            if (this.con != null)
                throw new Exception("A connection was has already been made");

            this.con = new SqlConnection(this.connectionString);
            this.con.Open();
        }

        /// <summary>
        /// Close the connection to the database
        /// </summary>
        private void Close()
        {
            if (this.con == null)
                throw new Exception("Connection was already closed");

            this.con.Close();
            this.con = null;
        }

        /// <summary>
        /// Read data from the database
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>
        protected DataTable GetData(string sqlCommand)
        {
            DataTable dt = new DataTable();

            try
            {
                this.Open();

                SqlCommand scmd = new SqlCommand(sqlCommand, this.con);

                dt.Load(scmd.ExecuteReader());

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.Close();
            }

            return dt;
        }

        /// <summary>
        /// Insert data into the database
        /// </summary>
        /// <param name="sqlCommand"></param>
        protected void InsertData(string sqlCommand)
        {
            try
            {
                this.Open();
                SqlCommand scmd = new SqlCommand(sqlCommand, this.con);

                scmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.Close();
            }
        }

        /// <summary>
        /// Deletes data from the database
        /// </summary>
        /// <param name="sqlCommand"></param>
        protected void DeleteData(string sqlCommand)
        {
            try
            {
                this.Open();
                SqlCommand scmd = new SqlCommand(sqlCommand, this.con);

                scmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.Close();
            }
        }

        protected void UpdateData(string sqlCommand)
        {
            try
            {
                this.Open();
                SqlCommand scmd = new SqlCommand(sqlCommand, this.con);

                scmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.Close();
            }
        }

        protected bool Login()
        {
            try
            {
                Open();
                Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }


    }
}