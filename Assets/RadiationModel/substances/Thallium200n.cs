
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium200n : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium200n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 199.97178d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Thallium200() } },

        };
    }
}
    
    