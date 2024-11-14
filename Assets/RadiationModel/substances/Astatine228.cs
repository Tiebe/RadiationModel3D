using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine228 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine228";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 228.04496d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    