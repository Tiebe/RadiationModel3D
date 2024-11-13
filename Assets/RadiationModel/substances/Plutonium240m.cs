
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium240m : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium240m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 240.05522d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Plutonium240() } },

        };
    }
}
    
    