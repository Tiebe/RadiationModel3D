using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine226 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine226";
        public override double halfLife { get; } = 420.0d;
        public override double atomicWeight { get; } = 226.03721d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    