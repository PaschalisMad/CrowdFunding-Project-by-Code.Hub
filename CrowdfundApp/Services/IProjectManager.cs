﻿using CrowdfundApp.Models;
using CrowdfundApp.Options;
using System;
using System.Collections.Generic;
using System.Text;


namespace CrowdfundApp.Services
{
    public interface IProjectManager
    {
        public Project CreateProject(ProjectOption projectOption);
        public List<FundingPackage> ShowFundingPackages();


    }
}
