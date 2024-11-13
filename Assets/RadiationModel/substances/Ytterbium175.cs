
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium175";
        public override double halfLife { get; } = 361584.0d;
        public override double atomicWeight { get; } = 174.94128d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lutetium175() } },

        };
    }
}
    
    