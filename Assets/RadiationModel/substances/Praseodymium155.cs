
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium155";
        public override double halfLife { get; } = 1.47d;
        public override double atomicWeight { get; } = 154.94051d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium155() } },

        };
    }
}
    
    