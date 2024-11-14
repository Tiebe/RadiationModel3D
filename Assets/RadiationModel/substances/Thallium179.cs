using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium179";
        public override double halfLife { get; } = 0.437d;
        public override double atomicWeight { get; } = 178.99112d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6d, new List<RadioactiveSubstance> { new AlphaParticle(7725047.4), new Gold175() } },

        };
    }
}
    
    