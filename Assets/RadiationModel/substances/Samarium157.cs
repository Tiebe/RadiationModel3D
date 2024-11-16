using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium157";
        public override double halfLife { get; } = 481.8d;
        public override double atomicWeight { get; } = 156.92842d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2781000.0), new Europium157() } },

        };
    }
}
    
    