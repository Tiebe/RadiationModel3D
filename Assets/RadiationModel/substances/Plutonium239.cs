
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium239";
        public override double halfLife { get; } = 760838112720.0d;
        public override double atomicWeight { get; } = 239.05216d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Uranium235() } },

            { 3.1e-12d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    