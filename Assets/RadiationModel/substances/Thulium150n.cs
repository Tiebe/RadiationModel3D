
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium150n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium150n";
        public override double halfLife { get; } = 0.0052d;
        public override double atomicWeight { get; } = 149.95096d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Thulium150() } },

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Thulium150m() } },

        };
    }
}
    
    