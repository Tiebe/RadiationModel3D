
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium239";
        public override double halfLife { get; } = 203558.4d;
        public override double atomicWeight { get; } = 239.05294d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Plutonium239() } },

        };
    }
}
    
    