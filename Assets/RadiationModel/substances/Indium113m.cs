
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium113m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium113m";
        public override double halfLife { get; } = 5968.44d;
        public override double atomicWeight { get; } = 112.90448d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Indium113() } },

        };
    }
}
    
    