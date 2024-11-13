
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic66n : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic66n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 65.9474d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Arsenic66() } },

        };
    }
}
    
    