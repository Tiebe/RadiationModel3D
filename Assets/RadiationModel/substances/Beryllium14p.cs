
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium14p : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium14p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 14.04452d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    