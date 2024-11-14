using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium162";
        public override double halfLife { get; } = 0.107d;
        public override double atomicWeight { get; } = 161.9759d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new List<RadioactiveSubstance> { new AlphaParticle(7265047.4), new Tantalum158() } },

        };
    }
}
    
    