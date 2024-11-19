using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium215";
        public override double halfLife { get; } = 0.014d;
        public override double atomicWeight { get; } = 215.01911d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9257002.09), new Actinium211() } },

        };
    }
}
    
    