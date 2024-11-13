
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium258";
        public override double halfLife { get; } = 0.00123d;
        public override double atomicWeight { get; } = 258.09821d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    