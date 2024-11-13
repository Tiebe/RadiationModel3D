
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium170";
        public override double halfLife { get; } = 11111040.0d;
        public override double atomicWeight { get; } = 169.93581d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.99869d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium170() } },

            { 0.00131d, new List<RadioactiveSubstance> { new Erbium170() } },

        };
    }
}
    
    