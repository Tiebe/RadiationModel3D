
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine225 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine225";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 225.03253d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    