
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium48 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium48";
        public override double halfLife { get; } = 1.767189312e+27d;
        public override double atomicWeight { get; } = 47.95252d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    