
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium251";
        public override double halfLife { get; } = 28338142896.0d;
        public override double atomicWeight { get; } = 251.07959d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Curium247() } },

        };
    }
}
    
    