﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.UtakmicaSO
{
    public class VratiUtakmiceSO : SystemOperationsBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            try
            {
                ResultList = repository.VratiListu(new Raspored()).Cast<object>().ToList();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}