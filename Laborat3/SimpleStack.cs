using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat3
{
   public class SimpleStack<T>
    {
        public class SimpleListItem<T>
        {  public T data { get; set; }
          public SimpleListItem<T> next { get; set; }
           public SimpleListItem(T param) { this.data = param; } }
        }

    }
