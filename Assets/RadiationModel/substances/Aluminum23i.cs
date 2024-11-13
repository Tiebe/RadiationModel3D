
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum23i : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum23i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 23.01983d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.001d, new List<RadioactiveSubstance> { new ProtonParticle(), new Magnesium22() } },

            { 0.036000000000000004d, new List<RadioactiveSubstance> { new ProtonParticle(), new Sodium21() } },

        };
    }
}
    
    