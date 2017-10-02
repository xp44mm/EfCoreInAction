﻿// Copyright (c) 2017 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT licence. See License.txt in the project root for license information.
namespace Test.Chapter11Listings.EfClasses
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Addresses AddressData { get; set; }
    }
}