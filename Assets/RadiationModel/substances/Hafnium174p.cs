using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium174p : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium174p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 173.9436d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00037), new Hafnium174() } },

        };
    }
}
    
    