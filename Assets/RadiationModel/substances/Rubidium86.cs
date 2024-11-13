
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium86";
        public override double halfLife { get; } = 1610928.0d;
        public override double atomicWeight { get; } = 85.91117d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium86() } },

            { 5.2e-05d, new List<RadioactiveSubstance> { new Krypton86() } },

        };
    }
}
    
    