using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium165";
        public override double halfLife { get; } = 0.98d;
        public override double atomicWeight { get; } = 164.95329d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7219000.0), new Europium165() } },

        };
    }
}
    
    