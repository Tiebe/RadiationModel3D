
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt60 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt60";
        public override double halfLife { get; } = 166349316.7728d;
        public override double atomicWeight { get; } = 59.93382d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Nickel60() } },

        };
    }
}
    
    