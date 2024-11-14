using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium176m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium176m";
        public override double halfLife { get; } = 11.4d;
        public override double atomicWeight { get; } = 175.9437d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.1d, new List<RadioactiveSubstance> { new BetaParticle(-1, 940800.0), new Lutetium176() } },

        };
    }
}
    
    