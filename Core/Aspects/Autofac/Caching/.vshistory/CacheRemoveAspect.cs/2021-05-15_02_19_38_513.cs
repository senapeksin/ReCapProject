﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Aspects.Autofac.Caching
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

        protected override void OnSuccess(IInvocation invocation) //metod başarılı olursa ekle demek .
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
