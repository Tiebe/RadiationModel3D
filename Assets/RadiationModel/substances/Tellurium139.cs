
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium139";
        public override double halfLife { get; } = 0.724d;
        public override double atomicWeight { get; } = 138.93537d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iodine139() } },

        };
    }
}
    
    