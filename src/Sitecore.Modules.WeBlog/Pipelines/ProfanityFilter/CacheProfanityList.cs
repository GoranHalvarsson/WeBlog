using System;
using System.Linq;
using Sitecore.Modules.WeBlog.Caching;

namespace Sitecore.Modules.WeBlog.Pipelines.ProfanityFilter
{
    public class CacheProfanityList : IProfanityFilterProcessor
    {
        public void Process(ProfanityFilterArgs args)
        {
            if (args.WordList.Any() && CacheManager.ProfanityFilterCache.WorList == null)
            {
                CacheManager.ProfanityFilterCache.WorList = args.WordList;
            }
        }
    }
}