using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium58 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium58";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 58.02354d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    