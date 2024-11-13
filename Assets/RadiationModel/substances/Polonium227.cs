
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium227";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 227.04539d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    