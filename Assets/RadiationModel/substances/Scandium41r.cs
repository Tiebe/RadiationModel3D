using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium41r : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium41r";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 40.97235d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.59d, new List<RadioactiveSubstance> { new ProtonParticle(), new Calcium40() } },
            { 0.41d, new List<RadioactiveSubstance> { new GammaParticle((2882350.0, 0.00043)), new Scandium41() } },

        };
    }
}
    
    