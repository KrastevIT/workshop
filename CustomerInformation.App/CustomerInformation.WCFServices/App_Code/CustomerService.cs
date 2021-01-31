using CustomerInformation.Data;
using CustomerInformation.Data.Models;
using CustomerInformation.Models.Addresses;
using CustomerInformation.Models.Customers;
using System;
using System.Collections.Generic;

public class CustomerService : ICustomerService
{
    public bool Create(CustomerCreateModel model)
    {
        try
        {
            var db = new CustomerInformationContext();

            var homeAddresses = new List<HomeAddress>();
            var officeAddresses = new List<OfficeAddress>();

            foreach (var homeAddress in model.HomeAddresses)
            {
                var phoneNumbers = new List<HomePhone>();
                foreach (var phoneNumber in homeAddress.PhoneNumbers)
                {
                    phoneNumbers.Add(new HomePhone { Number = phoneNumber });
                }

                homeAddresses.Add(new HomeAddress
                {
                    Address = homeAddress.Address,
                    HomePhones = phoneNumbers
                });
            }
            foreach (var officeAddress in model.OfficeAddresses)
            {
                var phoneNumbers = new List<OfficePhone>();
                foreach (var phoneNumber in officeAddress.PhoneNumbers)
                {
                    phoneNumbers.Add(new OfficePhone { Number = phoneNumber });
                }

                officeAddresses.Add(new OfficeAddress
                {
                    Address = officeAddress.Address,
                    OfficePhones = phoneNumbers
                });
            }

            var customer = new Customer
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                HomeAddresses = homeAddresses,
                OfficeAddresses = officeAddresses
            };

            db.Customers.Add(customer);
            var result = db.SaveChanges();
        }
        catch (Exception)
        {
            throw new InvalidOperationException("Invalid Add In DataBase");
        }

        return true;
    }

    //TODO
    private static ICollection<object> AddAddresses(ICollection<AddressCreateModel> addresses)
    {
        var genericAddresses = new List<object>();

        foreach (var address in addresses)
        {
            var phoneNumbers = new List<HomePhone>();
            foreach (var phoneNumber in address.PhoneNumbers)
            {
                phoneNumbers.Add(new HomePhone { Number = phoneNumber });
            }

            genericAddresses.Add(new
            {
                Address = address,
                PhoneNumbers = phoneNumbers
            });
        }

        return genericAddresses;
    }
}
