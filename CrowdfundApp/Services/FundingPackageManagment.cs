﻿using CrowdfundApp.Options;
using CrowdfundApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrowdfundApp.Models;

namespace CrowdfundApp.Services
{
    public class FundingPackageManagment: IFundingPackageManager
    {
        private CrmDbContext db;

        public FundingPackageManagment(CrmDbContext _db)
        {
            db = _db;
        }

        //Create new FundingPackage
        public FundingPackage CreateFundingPackage(FundingPackageOption fundingPackageOption)
        {
            FundingPackage fundingPackage = new FundingPackage
            {
                Price = fundingPackageOption.Price,
                Reward = fundingPackageOption.Reward
            };


            db.FundingPackages.Add(fundingPackage);
            db.SaveChanges();

            return fundingPackage;
        }


    }
}