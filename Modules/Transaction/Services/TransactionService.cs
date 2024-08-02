using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Modules.Transaction.Repositories;

namespace onboarding_backend.Modules.Transaction.Services
{
    public class TransactionService(TransactionRepository transactionRepository)
    {
        private readonly TransactionRepository _transactionRepository = transactionRepository;

    }
}