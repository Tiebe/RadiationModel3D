
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium247";
        public override double halfLife { get; } = 11196.0d;
        public override double atomicWeight { get; } = 247.07097d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.99965d, new List<RadioactiveSubstance> { new Berkelium247() } },

            { 0.00035000000000000005d, new List<RadioactiveSubstance> { new AlphaParticle(), new Curium243() } },

        };
    }
}
    
    