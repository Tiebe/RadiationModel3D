
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium129n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium129n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 128.92362d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Indium129() } },

        };
    }
}
    
    