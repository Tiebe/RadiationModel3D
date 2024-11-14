using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium139";
        public override double halfLife { get; } = 17.9d;
        public override double atomicWeight { get; } = 138.92979d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6982000.0), new Samarium139() } },

        };
    }
}
    
    