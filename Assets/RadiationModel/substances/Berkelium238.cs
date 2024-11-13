
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium238";
        public override double halfLife { get; } = 144.0d;
        public override double atomicWeight { get; } = 238.05821d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Curium238() } },

        };
    }
}
    
    