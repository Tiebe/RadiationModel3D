
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium49 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium49";
        public override double halfLife { get; } = 3430.8d;
        public override double atomicWeight { get; } = 48.95001d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Titanium49() } },

        };
    }
}
    
    