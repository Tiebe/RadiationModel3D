
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium197m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium197m";
        public override double halfLife { get; } = 0.54d;
        public override double atomicWeight { get; } = 196.97021d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Thallium197() } },

        };
    }
}
    
    