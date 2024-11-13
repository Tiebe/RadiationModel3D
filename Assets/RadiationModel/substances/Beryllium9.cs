
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium9 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium9";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 9.01218d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    