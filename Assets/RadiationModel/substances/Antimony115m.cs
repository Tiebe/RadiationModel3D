
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony115m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony115m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 114.9096d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Antimony115() } },

        };
    }
}
    
    