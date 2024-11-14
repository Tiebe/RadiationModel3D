using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury192 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury192";
        public override double halfLife { get; } = 17460.0d;
        public override double atomicWeight { get; } = 191.96563d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Gold192() } },

        };
    }
}
    
    