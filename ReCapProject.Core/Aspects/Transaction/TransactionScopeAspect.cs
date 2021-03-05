using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Castle.DynamicProxy;
using ReCapProject.Core.Utilities.İnterceptors;

namespace ReCapProject.Core.Aspects.Transaction
{
    public class TransactionScopeAspect:MethodInterception
    {
        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    invocation.Proceed();
                    transactionScope.Complete();
                }
                catch (System.Exception e)
                {
                    transactionScope.Dispose();
                    throw e;
                }
            }
        }
    }
}
