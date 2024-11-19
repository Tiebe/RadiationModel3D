using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium222";
        public override double halfLife { get; } = 0.0038d;
        public override double atomicWeight { get; } = 222.02368d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9807002.09), new Actinium218() } },

        };
    }
}
    
    