using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium133m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium133m";
        public override double halfLife { get; } = 0.167d;
        public override double atomicWeight { get; } = 132.93842d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13513900.0), new Tin133() } },

        };
    }
}
    
    