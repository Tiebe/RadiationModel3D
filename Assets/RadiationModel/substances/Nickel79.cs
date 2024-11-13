
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel79 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel79";
        public override double halfLife { get; } = 0.044d;
        public override double atomicWeight { get; } = 78.96977d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Copper79() } },

        };
    }
}
    
    