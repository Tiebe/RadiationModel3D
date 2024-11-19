using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony124n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony124n";
        public override double halfLife { get; } = 1212.0d;
        public override double atomicWeight { get; } = 123.90598d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new List<RadioactiveSubstance> { new GammaParticle((36800.0, 0.03369)), new Antimony124() } },
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((25900.00001, 0.04787)), new Antimony124m() } },

        };
    }
}
    
    