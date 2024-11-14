using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium225";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 225.03712d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    