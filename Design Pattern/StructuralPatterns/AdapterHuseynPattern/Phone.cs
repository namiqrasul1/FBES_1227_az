using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterHuseynPattern
{
    public interface Phone
    {
        string GetNaame();
        int GetCameraCount();
        double GetPrice();
    }
}
