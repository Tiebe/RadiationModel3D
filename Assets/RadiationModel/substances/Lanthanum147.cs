using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum147 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum147";
        public override double halfLife { get; } = 4.026d;
        public override double atomicWeight { get; } = 146.92842d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5336000.0), new Cerium147() } },

        };
    }
}
    
    