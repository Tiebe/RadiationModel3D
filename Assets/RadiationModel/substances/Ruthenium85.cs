
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium85";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 84.96712d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    