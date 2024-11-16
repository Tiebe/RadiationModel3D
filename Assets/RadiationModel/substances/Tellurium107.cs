using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium107";
        public override double halfLife { get; } = 0.00322d;
        public override double atomicWeight { get; } = 106.93488d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new List<RadioactiveSubstance> { new AlphaParticle(5027002.09), new Tin103() } },

        };
    }
}
    
    