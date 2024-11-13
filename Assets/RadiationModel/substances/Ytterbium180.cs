
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium180";
        public override double halfLife { get; } = 144.0d;
        public override double atomicWeight { get; } = 179.95199d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lutetium180() } },

        };
    }
}
    
    