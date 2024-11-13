
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium149p : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium149p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 148.94585d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Erbium149() } },

        };
    }
}
    
    