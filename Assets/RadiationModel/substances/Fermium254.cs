
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium254";
        public override double halfLife { get; } = 11664.0d;
        public override double atomicWeight { get; } = 254.08685d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.999408d, new List<RadioactiveSubstance> { new AlphaParticle(), new Californium250() } },

            { 0.0005920000000000001d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    