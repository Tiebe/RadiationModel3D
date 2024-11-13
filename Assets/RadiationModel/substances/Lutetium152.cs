
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium152";
        public override double halfLife { get; } = 0.65d;
        public override double atomicWeight { get; } = 151.96412d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium152() } },

        };
    }
}
    
    