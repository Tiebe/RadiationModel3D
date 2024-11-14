using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium157";
        public override double halfLife { get; } = 54648.0d;
        public override double atomicWeight { get; } = 156.92543d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1364900.0), new Gadolinium157() } },

        };
    }
}
    
    