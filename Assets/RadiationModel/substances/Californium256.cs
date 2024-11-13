
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium256";
        public override double halfLife { get; } = 738.0d;
        public override double atomicWeight { get; } = 256.09344d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    