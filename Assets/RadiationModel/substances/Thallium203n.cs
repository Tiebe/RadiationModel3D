
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium203n : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium203n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 202.97617d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Thallium203() } },

        };
    }
}
    
    