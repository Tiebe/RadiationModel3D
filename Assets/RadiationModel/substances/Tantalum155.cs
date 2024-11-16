using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum155 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum155";
        public override double halfLife { get; } = 0.0032d;
        public override double atomicWeight { get; } = 154.97425d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Hafnium154() } },

        };
    }
}
    
    