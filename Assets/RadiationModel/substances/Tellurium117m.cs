
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium117m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium117m";
        public override double halfLife { get; } = 0.103d;
        public override double atomicWeight { get; } = 116.90896d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Tellurium117() } },

        };
    }
}
    
    