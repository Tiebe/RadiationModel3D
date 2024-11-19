using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium162m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium162m";
        public override double halfLife { get; } = 24.3d;
        public override double atomicWeight { get; } = 161.93414d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.81d, new List<RadioactiveSubstance> { new GammaParticle((127000.0, 0.00976)), new Thulium162() } },
            { 0.19d, new List<RadioactiveSubstance> { new BetaParticle(1, 4984200.0), new Erbium162() } },

        };
    }
}
    
    