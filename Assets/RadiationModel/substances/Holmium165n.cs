using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium165n : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium165n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 164.9311d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00173, 715300.0), new Holmium165() } },

        };
    }
}
    
    