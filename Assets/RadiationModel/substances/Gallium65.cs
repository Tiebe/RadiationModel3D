
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium65 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium65";
        public override double halfLife { get; } = 907.98d;
        public override double atomicWeight { get; } = 64.93273d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zinc65() } },

        };
    }
}
    
    