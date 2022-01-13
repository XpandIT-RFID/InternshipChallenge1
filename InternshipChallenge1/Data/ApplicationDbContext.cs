﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static InternshipChallenge1.Models.AccountsDb;

namespace InternshipChallenge1.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public IList<Account> Accounts { get; set; }
        public IList<AccountsContent> AccountsContents { get; set; }
        public IList<AccountContentComment> AccountContentComments { get; set; }
    }
}
