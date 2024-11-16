using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium128";
        public override double halfLife { get; } = 0.816d;
        public override double atomicWeight { get; } = 127.92035d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9170900.0), new Tin128() } },

        };
    }
}
    
    