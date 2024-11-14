using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium268 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium268";
        public override double halfLife { get; } = 104400.0d;
        public override double atomicWeight { get; } = 268.12567d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    