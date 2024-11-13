
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium159";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 158.94662d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Promethium159() } },

        };
    }
}
    
    