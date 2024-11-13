
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium21 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium21";
        public override double halfLife { get; } = 0.12d;
        public override double atomicWeight { get; } = 21.01171d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Sodium21() } },

        };
    }
}
    
    