
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium227";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 227.04528d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    