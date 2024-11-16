using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium191 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium191";
        public override double halfLife { get; } = 0.022d;
        public override double atomicWeight { get; } = 190.99456d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8515002.09), new Lead187() } },

        };
    }
}
    
    