using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinForm.Abstract
{
    public class Test1 : AbstractCity
    {
        public override string GetNameAbstract(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class Test2
    {

        IDB service;
        public Test2(IDB service)
        {
            this.service = service;
        }

        
    }

    public class OracleService : IDB
    {
        public string GetRegionsAll()
        {
            throw new NotImplementedException();
        }

        public string ReginAddEdit(Region region)
        {
            throw new NotImplementedException();
        }
    }

    public class PGService : IDB
    {
        public string GetRegionsAll()
        {
            throw new NotImplementedException();
        }

        public string ReginAddEdit(Region region)
        {
            throw new NotImplementedException();
        }
    }
    public interface IDB
    {   
        public string GetRegionsAll();
        public string ReginAddEdit(Region region);
    }


    public abstract class AbstractCity
    {
        public string Name { get; set; }
        public string GetName(string name)
        {
            return "Hello " + name;
        }
        public abstract string GetNameAbstract(string name);
        public virtual string GetNameVirtual(string name)
        {
            return "Hello " + name;
        }
    }


    public class Region
    {
        public int RegionID { get; set; }
    }
}
