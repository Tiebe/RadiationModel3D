
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium82n : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium82n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 81.92747d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Yttrium82() } },

        };
    }
}
    
    