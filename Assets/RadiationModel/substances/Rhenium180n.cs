
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium180n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium180n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 179.95461d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Rhenium180() } },

        };
    }
}
    
    