using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium177p : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium177p";
        public override double halfLife { get; } = 13858560.0d;
        public override double atomicWeight { get; } = 176.94481d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.773d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1467000.0), new Hafnium177() } },
            { 0.22699999999999998d, new List<RadioactiveSubstance> { new GammaParticle((970200.00002, 0.00128)), new Lutetium177() } },

        };
    }
}
    
    