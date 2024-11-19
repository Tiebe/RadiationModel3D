using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium210 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium210";
        public override double halfLife { get; } = 190.8d;
        public override double atomicWeight { get; } = 209.99641d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.71d, new List<RadioactiveSubstance> { new AlphaParticle(7692002.09), new Astatine206() } },

        };
    }
}
    
    