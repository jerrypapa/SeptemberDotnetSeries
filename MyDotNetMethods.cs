using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeptemberDotnetSeries;

public class MyDotNetMethods //My Dot Net Methods
{
    // Is wantam

    //enhancemenent
    //obvious error
    public bool IsWantam(int voterTurnout,
        int ganneredVotes)
    {
        //error handling

        try
        {
            int percentageGained =
            (ganneredVotes / voterTurnout) * 100;

            if (percentageGained < 50)
                return true;
            return false;

        }
        catch (Exception)
        {

            throw;
        }

        
    }

}
