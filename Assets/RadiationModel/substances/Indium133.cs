
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium133";
        public override double halfLife { get; } = 0.163d;
        public override double atomicWeight { get; } = 132.93807d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin133() } },

        };
    }
}
    
    