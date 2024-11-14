using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon38 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon38";
        public override double halfLife { get; } = 0.063d;
        public override double atomicWeight { get; } = 37.99552d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10450000.0), new Phosphorus38() } },

        };
    }
}
    
    