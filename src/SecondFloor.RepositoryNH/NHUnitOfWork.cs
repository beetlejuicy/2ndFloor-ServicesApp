﻿using System;
using NHibernate;
using SecondFloor.Infrastructure.Model;
using SecondFloor.Infrastructure.Repository;

namespace SecondFloor.RepositoryNH
{
    public class NHUnitOfWork : IUnitOfWork
    {
        public void SaveNew(IAggregateRoot entity)
        {
            SessionProvider.GetCurrentSession().Save(entity);
        }

        public void SaveAmended(IAggregateRoot entity)
        {
            SessionProvider.GetCurrentSession().SaveOrUpdate(entity);
        }

        public void SaveRemoved(IAggregateRoot entity)
        {
            SessionProvider.GetCurrentSession().Delete(entity);
        }

        public void Commit()
        {
            using (ITransaction transaction = SessionProvider.GetCurrentSession().BeginTransaction())
            {
                try
                {
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}