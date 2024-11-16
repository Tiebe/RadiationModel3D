using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium245";
        public override double halfLife { get; } = 260344854000.0d;
        public override double atomicWeight { get; } = 245.06549d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6646402.09), new Plutonium241() } },
            { 6.1e-09d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    