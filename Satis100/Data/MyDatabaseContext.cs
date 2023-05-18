
using Satis100.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Satis100.Data
{


    public class MyDatabaseContext : IDisposable
    {
        private readonly string connectionString;
        private readonly SqlConnection connection;

        public MyDatabaseContext()
        {
            this.connectionString = @"Data Source=DESKTOP-JUKJKO7;Initial Catalog=Satis100;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public List<Make> GetMakes()
        {
            List<Make> makes = new List<Make>();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Make", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["Id"];
                        string name = (string)reader["Name"];

                        Make make = new Make
                        {
                            Id = id,
                            Name = name
                        };

                        makes.Add(make);
                    }
                }
            }

            return makes;
        }
        public List<Model> GetModels(int makeId)
        {
            List<Model> models = new List<Model>();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Model WHERE MakeId = @MakeId", connection))
            {
                command.Parameters.AddWithValue("@MakeId", makeId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["Id"];
                        string name = (string)reader["Name"];
                        int cost = (int)reader["Cost"];

                        Model model = new Model

                        {
                            Id = id,
                            MakeId = makeId,
                            Name = name,
                            Cost = cost
                        };

                        models.Add(model);
                    }
                }
            }

            return models;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Customer", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["Id"];
                        string name = (string)reader["Name"];
                        string address = (string)reader["Address"];
                        string phoneNumber = (string)reader["PhoneNumber"];

                        Customer customer = new Customer
                        {
                            Id = id,
                            Name = name,
                            Address = address,
                            PhoneNumber = phoneNumber
                        };

                        customers.Add(customer);
                    }
                }
            }

            return customers;
        }
        public void InsertFacture(Facture facture)
        {

            string factureQuery = "INSERT INTO Facture (TotalCost, CustomerId, Date) OUTPUT INSERTED.ID VALUES (@TotalCost, @CustomerId, @Date)";
            

            using (SqlCommand factureCommand = new SqlCommand(factureQuery, connection))

            {

                factureCommand.Parameters.AddWithValue("@TotalCost", facture.TotalCost);
                factureCommand.Parameters.AddWithValue("@CustomerId", facture.Customer.Id);
                factureCommand.Parameters.AddWithValue("@Date", facture.Date);
                int insertedId = (int)factureCommand.ExecuteScalar();



                


            }

        }
        public List<Facture> GetAllFactures()
        {
            List<Facture> factures = new List<Facture>();

            string factureQuery = "SELECT Id, CustomerId, TotalCost, Date FROM Facture";
            string customerQuery = "SELECT Id, Name,Address,PhoneNumber FROM Customer WHERE Id = @CustomerId";
            string modelsQuery = "SELECT m.Id, m.Name FROM Model m INNER JOIN FactureModel fm ON m.Id = fm.ModelId WHERE fm.FactureId = @FactureId";



            using (SqlCommand factureCommand = new SqlCommand(factureQuery, connection))
            {
                using (SqlDataReader factureReader = factureCommand.ExecuteReader())
                {
                    while (factureReader.Read())
                    {
                        Facture facture = new Facture
                        {
                            Id = (int)factureReader["Id"],
                            CustomerId = (int)factureReader["CustomerId"],
                            TotalCost = (int)factureReader["TotalCost"],
                            Date = (DateTime)factureReader["Date"]
                        };
                        using (SqlCommand customerCommand = new SqlCommand(customerQuery, connection))
                        {
                            customerCommand.Parameters.AddWithValue("@CustomerId", facture.CustomerId);

                            using (SqlDataReader customerReader = customerCommand.ExecuteReader())
                            {
                                if (customerReader.Read())
                                {
                                    Customer customer = new Customer
                                    {
                                        Id = (int)customerReader["Id"],
                                        Name = (string)customerReader["Name"],
                                        PhoneNumber = (string)customerReader["PhoneNumber"],
                                        Address = (string)customerReader["Address"]
                                    };

                                    facture.Customer = customer;
                                }
                            }
                        }

                        using (SqlCommand modelsCommand = new SqlCommand(modelsQuery, connection))
                        {
                            modelsCommand.Parameters.AddWithValue("@FactureId", facture.Id);

                            using (SqlDataReader modelsReader = modelsCommand.ExecuteReader())
                            {
                                while (modelsReader.Read())
                                {
                                    Model model = new Model
                                    {
                                        Id = (int)modelsReader["Id"],
                                        Name = (string)modelsReader["Name"]
                                    };

                                    facture.Models.Add(model);
                                }
                            }
                        }

                        factures.Add(facture);
                    }
                }
            }


            return factures;
        }

        public List<FactureDetail> GetAllFactureDetails()
        {
            List<FactureDetail> factureDetails = new List<FactureDetail>();

            using (SqlCommand command = new SqlCommand("SELECT TotalCost,c.Name as CustomerName,c.Address,c.PhoneNumber,Date FROM Facture f LEFT JOIN Customer c ON c.Id=f.CustomerId", connection))
            {
                

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        
                        
                        FactureDetail factureDetail = new FactureDetail

                        {
                            
                            CustomerAddress = (string)reader["Address"],
                            CustomerName = (string)reader["CustomerName"],
                            TotalCost = (int)reader["TotalCost"],
                            CustomerPhone = (string)reader["PhoneNumber"],
                            Date = (DateTime)reader["Date"]



                        };

                        factureDetails.Add(factureDetail);
                    }
                }
            }

            return factureDetails;
        }








        public void Dispose()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}



