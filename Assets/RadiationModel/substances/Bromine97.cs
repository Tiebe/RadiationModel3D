
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine97 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine97";
        public override double halfLife { get; } = 0.04d;
        public override double atomicWeight { get; } = 96.9635d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    