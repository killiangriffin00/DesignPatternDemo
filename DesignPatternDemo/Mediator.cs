using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo
{
    public interface Mediator
    {
        public abstract void notify(object sender, string e);
    }
}
