
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium162";
        public override double halfLife { get; } = 504.0d;
        public override double atomicWeight { get; } = 161.93099d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium162() } },

        };
    }
}
    
    