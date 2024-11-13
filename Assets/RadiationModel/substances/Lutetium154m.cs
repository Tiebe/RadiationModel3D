
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium154m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium154m";
        public override double halfLife { get; } = 1.12d;
        public override double atomicWeight { get; } = 153.95749d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium154() } },

        };
    }
}
    
    