using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium179p : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium179p";
        public override double halfLife { get; } = 0.00047d;
        public override double atomicWeight { get; } = 178.9558d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((5408000.0, 0.00023)), new Rhenium179() } },

        };
    }
}
    
    