
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium239n : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium239n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 239.05549d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    