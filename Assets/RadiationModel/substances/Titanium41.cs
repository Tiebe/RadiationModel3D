
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium41 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium41";
        public override double halfLife { get; } = 0.0819d;
        public override double atomicWeight { get; } = 40.98315d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Scandium41() } },

        };
    }
}
    
    