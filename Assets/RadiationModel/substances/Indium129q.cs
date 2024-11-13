
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium129q : RadioactiveSubstance
    {
        public override string name { get; } = "Indium129q";
        public override double halfLife { get; } = 0.11d;
        public override double atomicWeight { get; } = 128.9239d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Indium129() } },

        };
    }
}
    
    