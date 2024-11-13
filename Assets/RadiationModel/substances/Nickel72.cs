
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel72 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel72";
        public override double halfLife { get; } = 1.57d;
        public override double atomicWeight { get; } = 71.94179d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Copper72() } },

        };
    }
}
    
    