using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL.converts
{
   public  class CustomersConvert
    {

            public static CustomersEntities ConvertToEntities(customer c)
            {
            CustomersEntities nc = new CustomersEntities()
            {
                id = c.cusId,
                name = c.cusName,
                pin = (short)c.pin,
                card = c.cusCard
            };
                return nc;
            }
            public static customer ConvertToDB(CustomersEntities c)
            {
                customer nc = new customer()
                { 
                    cusId = c.id,
                    cusName = c.name,
                    pin = c.pin,
                    cusCard = c.card
                   
                };
                return nc;
            }


            public static List<CustomersEntities> ConvertListToEntities(List<customer> listCustomer)
            {
                List<CustomersEntities> customerList = new List<CustomersEntities>();
                listCustomer.ForEach(c =>
                {
                    customerList.Add(ConvertToEntities(c));
                });
                return customerList;
            }

        public static List<customer> ConvertListToDB(List<CustomersEntities> listCustomer)
        {
            List<customer> customerList = new List<customer>();
            listCustomer.ForEach(c =>
            {
                customerList.Add(ConvertToDB(c));
            });
            return customerList;
        }
       
        }
    }


