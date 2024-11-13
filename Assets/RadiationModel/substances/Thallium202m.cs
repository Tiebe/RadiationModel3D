
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium202m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium202m";
        public override double halfLife { get; } = 0.00059d;
        public override double atomicWeight { get; } = 201.97313d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Thallium202() } },

        };
    }
}
    
    