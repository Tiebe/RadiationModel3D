
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium40 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium40";
        public override double halfLife { get; } = 0.0524d;
        public override double atomicWeight { get; } = 39.99035d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Scandium40() } },

        };
    }
}
    
    