using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks
{
  [MemoryDiagnoser]
  public class InvokeVsDirect
  {
    private static Func<object, object> _func = (o) => new object();
    private static object _o = new object();

    [Benchmark]
    public void Invoke()
    {
      var o = _func.Invoke(_o);
    }

    [Benchmark]
    public void InvokeDirect()
    {
      var o = _func(_o);
    }
  }
}
