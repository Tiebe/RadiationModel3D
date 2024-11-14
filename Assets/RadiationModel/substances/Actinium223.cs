using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium223";
        public override double halfLife { get; } = 126.0d;
        public override double atomicWeight { get; } = 223.01914d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99d, new List<RadioactiveSubstance> { new AlphaParticle(7803047.4), new Francium219() } },

        };
    }
}
    
    