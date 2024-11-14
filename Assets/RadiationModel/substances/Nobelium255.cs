using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium255";
        public override double halfLife { get; } = 211.2d;
        public override double atomicWeight { get; } = 255.0932d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new List<RadioactiveSubstance> { new BetaParticle(1, 1970000.0), new Mendelevium255() } },
            { 0.3d, new List<RadioactiveSubstance> { new AlphaParticle(9448047.4), new Fermium251() } },

        };
    }
}
    
    