
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum148 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum148";
        public override double halfLife { get; } = 1.414d;
        public override double atomicWeight { get; } = 147.93268d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium148() } },

        };
    }
}
    
    