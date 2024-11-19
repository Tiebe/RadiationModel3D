using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium166m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium166m";
        public override double halfLife { get; } = 84.6d;
        public override double atomicWeight { get; } = 165.93989d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.58d, new List<RadioactiveSubstance> { new BetaParticle(1, 5604000.0), new Ytterbium166() } },
            { 0.42d, new List<RadioactiveSubstance> { new GammaParticle((31000.0, 0.03999)), new Lutetium166() } },

        };
    }
}
    
    