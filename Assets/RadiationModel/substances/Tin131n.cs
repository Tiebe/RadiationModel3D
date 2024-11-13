
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin131n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin131n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 130.92207d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Tin131() } },

        };
    }
}
    
    