
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin123q : RadioactiveSubstance
    {
        public override string name { get; } = "Tin123q";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 122.90864d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Tin123() } },

        };
    }
}
    
    