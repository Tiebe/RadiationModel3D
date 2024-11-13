
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium43 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium43";
        public override double halfLife { get; } = 0.0793d;
        public override double atomicWeight { get; } = 42.98076d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Titanium43() } },

        };
    }
}
    
    