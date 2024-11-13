
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon28r : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon28r";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 27.99039d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    