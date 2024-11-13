
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium234";
        public override double halfLife { get; } = 52.0d;
        public override double atomicWeight { get; } = 234.05016d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.71d, new List<RadioactiveSubstance> { new BetaParticle(), new Americium234() } },

            { 0.27d, new List<RadioactiveSubstance> { new AlphaParticle(), new Plutonium230() } },

            { 0.02d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    