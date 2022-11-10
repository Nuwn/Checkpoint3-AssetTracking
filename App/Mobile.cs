using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint3_AssetTracking.App
{
    internal class Mobile : Computer
    {
        public Mobile(): base() {}

        public Mobile(string brand, string model) : base(brand, model){}

        public override string GetCategory => GetType().Name;
    }
}
