
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium244";
        public override double halfLife { get; } = 137.4d;
        public override double atomicWeight { get; } = 244.06789d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Plutonium244() } },

        };
    }
}
    
    