
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium148";
        public override double halfLife { get; } = 56.8d;
        public override double atomicWeight { get; } = 147.92442d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium148() } },

        };
    }
}
    
    