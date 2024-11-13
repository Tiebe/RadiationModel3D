
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium160n : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium160n";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 159.92895d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Holmium160() } },

        };
    }
}
    
    