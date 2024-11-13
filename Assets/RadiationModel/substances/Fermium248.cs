
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium248";
        public override double halfLife { get; } = 34.5d;
        public override double atomicWeight { get; } = 248.07719d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Californium244() } },

            { 0.001d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    