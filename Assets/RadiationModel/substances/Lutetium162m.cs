using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium162m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium162m";
        public override double halfLife { get; } = 90.0d;
        public override double atomicWeight { get; } = 161.94341d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7111000.0), new Ytterbium162() } },

        };
    }
}
    
    