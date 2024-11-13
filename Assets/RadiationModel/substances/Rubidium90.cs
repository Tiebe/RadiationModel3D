
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium90";
        public override double halfLife { get; } = 158.0d;
        public override double atomicWeight { get; } = 89.9148d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium90() } },

        };
    }
}
    
    