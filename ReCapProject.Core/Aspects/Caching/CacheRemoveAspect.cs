using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using ReCapProject.Core.CrossCuttingConcerns.Caching;
using ReCapProject.Core.Utilities.İnterceptors;
using ReCapProject.Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace ReCapProject.Core.Aspects.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
